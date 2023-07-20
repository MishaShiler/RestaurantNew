using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private readonly RestaurantContext _context;
        public OrderController(RestaurantContext context)
        {
            RestaurantContext db = new RestaurantContext();

            _context = context;
        }


        private static List<string> _orders = new List<string>();

        [Route("Get All")]
        [HttpGet]
        public ActionResult<List<string>> GetAll()
        {
            RestaurantContext db = new RestaurantContext();

            return _orders;
        }

        [Route("Get Single")]
        [HttpGet]
        public ActionResult<List<string>> GetSingle(int index)
        {
            RestaurantContext db = new RestaurantContext();

            return _orders;
        }

        [Route("Add")]
        [HttpPost]
        public ActionResult<List<Order>> Post(Order order)
        {
            if (order != null)
            {
                _context.Orders.Add(order);
                _context.SaveChanges();

            }
            var orders = _context.Orders.ToList();
            return orders;
        }

        [Route("Update")]
        [HttpPut]

        public ActionResult<string> Put(Order order)
        {
            RestaurantContext db = new RestaurantContext();
            var OrderFromBase = db.Orders.FirstOrDefault(o => o.Id == order.Id);
            if (OrderFromBase != null)
            {
                OrderFromBase.Id = order.Id;
                OrderFromBase.CustomerId = order.CustomerId;
                OrderFromBase.Created = order.Created;
                OrderFromBase.RestaurantId = order.RestaurantId;
                OrderFromBase.ShippingAddress = order.ShippingAddress;
                OrderFromBase.StatusId = order.StatusId;
                OrderFromBase.OrderTypeId = order.OrderTypeId;
                db.SaveChanges();
                return "Order Updated";
            }

            return "Order Not Found";
        }
                [Route("Delete")]
                [HttpDelete]
                public ActionResult<List<string>> Delete(int index)
                {
                    RestaurantContext db = new RestaurantContext();

                    _orders.Remove(_orders[index]);
                    return _orders;
                }


            }
}
