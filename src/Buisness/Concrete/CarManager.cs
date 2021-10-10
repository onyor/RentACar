using Buisness.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal = new EfCarDal();
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car car)
        {
            _carDal.Add(car);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return new List<Car>(_carDal.GetAll());
        }

        public List<Car> GetAllByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetBrands(int brandIid)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int carId)
        {
            return _carDal.Get(c => c.CarId == carId);
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
