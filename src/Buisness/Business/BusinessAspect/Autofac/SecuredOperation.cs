﻿using Business.Constants;
using Castle.DynamicProxy;
using Core.Extensions;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Business.Business.BusinessAspect.Autofac
{
    public class SecuredOperation : MethodInterception
    {
        private readonly string[] _roles;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public SecuredOperation(params string[] roles)
        {
            _roles = roles;
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();
        }
        protected override void OnBefore(IInvocation invocation)
        {
            var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();

            foreach (var role in _roles)
            {
                if (roleClaims.Contains(role))
                {
                    return;  
                }
            }
            throw new Exception(Messages.AuthorizationDenied);
        }
    }

}
