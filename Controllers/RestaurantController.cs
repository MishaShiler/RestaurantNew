using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.DbModels;
using Restaurant.Dto.RestaurantDto;
using Restaurant.Filters;
using System.Data.Common;
using System.Security.Claims;

namespace Restaurant.Controllers


{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase

    {
        private readonly RestaurantContext _context;
                public RestaurantController(RestaurantContext context)
                {
                    _context = context;
                }


        private static List<string> _restaurant = new List<string>();

        [Route("Get All")]
        [HttpGet]
        public ActionResult<List<string>>GetAll()
        {
            RestaurantContext db = new RestaurantContext();
            return _restaurant;
        }

        [Route("Get Single")]
        [HttpGet]
        public ActionResult<List<string>> GetSingle(int index)
        {
            RestaurantContext db = new RestaurantContext();
            return _restaurant;
        }


        //[Route("Add")]
        //[HttpPost]
        //public ActionResult<List<string>> Post(DbModels.Restaurant restaurant)
        //{
        //    _context.Restaurants.Add(restaurant);

        //    _context.SaveChanges();
        //    return Ok(restaurant);

        //}




        //[Route("Add")]
        //[HttpPost]
        //public ActionResult<List<string>> Post(DbModels.Restaurant restaurant)
        //{
        //    if (restaurant != null)
        //    {
        //        _context.Restaurants.Add(restaurant);
        //        _context.SaveChanges();
        //        return Ok(restaurant);

        //    }
        //    var restaurants = restaurant.ToList();
        //    return Ok(restaurants);
        //}

        [Route("Update")]
        [HttpPut]
        public ActionResult<string> Put(DbModels.Restaurant restaurant)
        {
            RestaurantContext db = new RestaurantContext();
            var RestaurantFromBase = db.Restaurants.FirstOrDefault(r => r.Id == restaurant.Id);
            if (RestaurantFromBase != null)
            {
                RestaurantFromBase.Id = restaurant.Id;
                RestaurantFromBase.Name = restaurant.Name;
                RestaurantFromBase.Address = restaurant.Address;
                RestaurantFromBase.PhoneNumber = restaurant.PhoneNumber;
                db.SaveChanges();
                return "Restaurant Updated";
            }

            return "Restaurant Not Found";
        }

        [Route("Delete")]
        [HttpDelete]

        public ActionResult<List<string>> Delete(int index)
        {
            RestaurantContext db = new RestaurantContext();
            _restaurant.Remove(_restaurant[index]);
            return _restaurant;
        }
    }
}
