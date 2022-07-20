using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RentACarDBContext _context;

        private EfCarDal _carDal;
        private EfUserDal _userDal;
        public UnitOfWork(RentACarDBContext context)
        {
            _context = context;
        }
        public ICarDal Cars => _carDal ?? new EfCarDal();

        public IUserDal Users => _userDal ?? new EfUserDal();

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
