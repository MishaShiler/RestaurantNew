using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.DbModels;
using System.Collections.Generic;


namespace Restaurant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly RestaurantContext _context;
        public CustomerController(RestaurantContext context)
        {
            _context = context;
        }

        private static readonly List<string> _customer = new List<string>();

        [Route("Get Single")]
        [HttpGet]
        public async Task<ActionResult<Customer>> GetSingle(int id)
        {
            RestaurantContext db = new RestaurantContext();
            var customer = db.Customers.FirstOrDefault(x => x.Id == id);
           
            return customer;
        }

        [Route("Get All")]
        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetAll()
        {

            RestaurantContext db = new RestaurantContext();
            var customers = db.Customers.ToList();
            return customers;
        }

       

        [Route("Add")]
        [HttpPost]
        public async Task<ActionResult<List<Customer>>> Post(Customer customer)
        {
            if (customer != null) 
            {
                _context.Customers.Add(customer);
                _context.SaveChanges();

            }
            var customers = _context.Customers.ToList();
            return customers;
        }

        [Route("Update")]
        [HttpPut]
        public async Task<ActionResult<string>> Put(Customer customer)
        {
            RestaurantContext db = new RestaurantContext();
            var CustomerFromBase = db.Customers.FirstOrDefault(c => c.Id == customer.Id);
            if (CustomerFromBase != null)
            {
                CustomerFromBase.FirstName = customer.FirstName;
                CustomerFromBase.LastName = customer.LastName;
                CustomerFromBase.PhoneNumber = customer.PhoneNumber;
                db.SaveChanges();
                return "Customer Updated";
            }
            
            return "Customer Not Found";

        }

        [Route("Delete")]
        [HttpDelete]
        public async Task<ActionResult<string>> Delete(int id)
        {
            RestaurantContext db = new RestaurantContext();
            var customer = db.Customers.FirstOrDefault(x => x.Id == id);
            if (customer != null)
            {
                db.Customers.Remove(customer);
                db.SaveChanges();
                return "Customer Deleted";
            }
            else
            {
                return "Customer Not Found";
            }

            
        }
    }
}
