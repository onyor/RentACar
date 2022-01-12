using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete.Identity;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            if (user != null)
            {
                _userDal.Add(user);

                return new SuccessResult();
            }

            return new ErrorResult();
        }

        public IDataResult<User> GetByMail(string email)
        {
            var result = _userDal.Get(u => u.Email == email);

            if (result != null)
            {
                return new SuccessDataResult<User>(result);
            }
            return new ErrorDataResult<User>();

        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            if (user != null)
            {
                var claims = _userDal.GetClaims(user);
                return new SuccessDataResult<List<OperationClaim>>(claims);
            }

            return new ErrorDataResult<List<OperationClaim>>("Claimlere ulaşılamadı.");
        }
    }
}
