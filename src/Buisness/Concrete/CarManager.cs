using Buisness.Abstract;
using Core.Utilities.Results;
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


        public List<Car> GetAllByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Car> GetByCar(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == carId));
        }


        IResult ICarService.Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult();
        }

        IResult ICarService.Delete(int id)
        {
            return new SuccessResult();

        }

        IDataResult<List<Car>> ICarService.GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());

        }

        IDataResult<List<Car>> ICarService.GetAllByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        IResult ICarService.Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult();
        }
    }
}
