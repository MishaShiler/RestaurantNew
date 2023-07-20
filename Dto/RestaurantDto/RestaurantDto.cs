namespace Restaurant.Dto.RestaurantDto
{
    public class RestaurantDto
    {
        public partial class Restaurant
        {
            public int Id { get; set; }

            public string Name { get; set; } = null!;

            public string Address { get; set; } = null!;

            public string PhoneNumber { get; set; } = null!;
        }
    }
}
