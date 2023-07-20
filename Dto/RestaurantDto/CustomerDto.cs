namespace Restaurant.Dto.RestaurantDto
{
    public class CustomerDto
    {
        public partial class Customer
        {
            public int Id { get; set; }

            public string FirstName { get; set; } = null!;

            public string LastName { get; set; } = null!;

            public string PhoneNumber { get; set; } = null!;
        }

    }
}
