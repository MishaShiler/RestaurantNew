
using Restaurant.Services.CustomerService;

namespace Restaurant.Services.Customer
{
    public interface ICustomerService
    {
        Task<ServiceResponse<List<GetCustomerDto>>> GetAllCustomers();
        Task<ServiceResponse<GetCustomerDto>> GetCustomerById(int id);
        Task<ServiceResponse<List<GetCustomerDto>>> AddCustomer(AddCustomerDto Customer);
        Task<ServiceResponse<GetCustomerDto>> UpdateCustomer(UpdateCustomerDto Customer);
        Task<ServiceResponse<List<GetCustomerDto>>> DeleteCustomer(int id);
    }
}
