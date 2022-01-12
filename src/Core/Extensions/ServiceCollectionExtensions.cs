using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Extensions
{
    public static class ServiceCollentionExtensions
    {
        public static IServiceCollection AddDependencyResolvers
            (this IServiceCollection serviceCollention, ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
                module.Load(serviceCollention);
            }

            return ServiceTool.Create(serviceCollention);
        }
    }
}