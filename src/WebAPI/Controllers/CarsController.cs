using Buisness.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : Controller
    {
        CarManager _carManager;
        ICarDal _efCarDal;
        public CarsController()
        {
            _efCarDal = new EfCarDal();
            _carManager = new CarManager(_efCarDal);
        }


        [HttpGet("allCar")]
        public List<Car> GetAll()
        {
            var result = _carManager.GetAll();
            return result.Data;
        }
    }
}
