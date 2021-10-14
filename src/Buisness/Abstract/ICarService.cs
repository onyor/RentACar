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
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetAllByCategoryId(int id);
        IDataResult<Car> GetByCar(int carId);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(int id);
    }
}
