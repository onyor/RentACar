using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface ICarService
    {
        public IDataResult<List<Car>> GetAll();
        public IDataResult<List<Car>> GetAllByBrandId(int id);
        public IDataResult<Car> GetByCar(int carId);
        public IResult Add(Car car);
        public IResult Update(Car car);
        public IResult Delete(int id);
    }
}
