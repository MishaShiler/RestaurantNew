namespace Restaurant.Services.AuthServices
{
    public interface IAuthService
    {
        Task<Customer_User> Register(Customer_User user, string password);
        Task<Customer_User> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}
