using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        public IDataResult<List<Car>> GetAll();
        public IDataResult<List<Car>> GetAllByBrandId(int id);
        public IDataResult<Car> GetById(int carId);
        public IResult Add(Car car);
        public IResult Update(Car car);
        public IResult Delete(int id);
        public IResult AddTransactionalTest(Car car);
    }
}
