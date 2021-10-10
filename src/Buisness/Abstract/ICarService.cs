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
        List<Car> GetAll();
        List<Car> GetAllByCategoryId(int id);
        List<Car> GetBrands(int brandIid);
        string GetById(int carId);
        void Add(Car car);
        void Update(Car car);
        void Delete(int id);
    }
}
