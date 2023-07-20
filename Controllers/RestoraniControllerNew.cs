//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using System.Linq;

//namespace Restaurant.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class RestoraniControllerNew : ControllerBase
//    {

//        private readonly RestaurantContext _context;
//        public RestoraniControllerNew(RestaurantContext context)
//        {
//            _context = context;
//        }

//        private static readonly List<string> _restorani = new List<string>();

//        [Route("Get Single")]
//        [HttpGet]
//        public async Task<ActionResult<Customer>> GetSingle(int id)
//        {
//            RestaurantContext db = new RestaurantContext();
//            var restorani = db.Restaurants.FirstOrDefault(x => x.Id == id);

//            return Ok(restorani);
//        }

//        [Route("Get All")]
//        [HttpGet]
//        public async Task<ActionResult<List<Customer>>> GetAll()
//        {

//            RestaurantContext db = new RestaurantContext();
//            var restornebi = db.Restaurants.ToList();
//            return Ok(restornebi);
//        }



//        [Route("Add")]
//        [HttpPost]
//        public async Task<ActionResult<List<RestaurantAddNew>>> Post(RestaurantAddNew restorani)
//        {
//            if (restorani != null)
//            {
//                _context.Restaurants.All(restorani);
//                _context.SaveChanges();

//            }
//            var restornebi = _context.Restaurants.ToList();
//            return Ok(restornebi);
//        }

//        [Route("Update")]
//        [HttpPut]
//        public async Task<ActionResult<string>> Put(RestaurantAddNew restorani)
//        {
//            RestaurantContext db = new RestaurantContext();
//            var RestFromBase = db.Restaurants.FirstOrDefault(c => c.Id == restorani.Id);
//            if (RestFromBase != null)
//            {
//                RestFromBase.FirstName = customer.FirstName;
//                RestFromBase.LastName = customer.LastName;
//                RestFromBase.PhoneNumber = customer.PhoneNumber;
//                db.SaveChanges();
//                return "Customer Updated";
//            }

//            return "Customer Not Found";

//        }

//        [Route("Delete")]
//        [HttpDelete]
//        public async Task<ActionResult<string>> Delete(int id)
//        {
//            RestaurantContext db = new RestaurantContext();
//            var customer = db.Customers.FirstOrDefault(x => x.Id == id);
//            if (customer != null)
//            {
//                db.Customers.Remove(customer);
//                db.SaveChanges();
//                return "Customer Deleted";
//            }
//            else
//            {
//                return "Customer Not Found";
//            }
//        }
//}
