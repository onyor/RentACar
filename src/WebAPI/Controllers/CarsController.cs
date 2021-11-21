using Buisness.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
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
        public IActionResult GetAll()
        {
            return (IActionResult)_carManager.GetAll();
        }
    }
}
