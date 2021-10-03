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
        string GetById(int carId);
        void Add(Car car);
        void Update(Car car);
        void Delete(int id);
    }
}
