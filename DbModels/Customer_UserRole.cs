namespace Restaurant.DbModels
{
    public class Customer_UserRole
    {
        public int Id { get; set; } 
        public int UserId { get; set; }
        public Customer_User User { get; set; }
        public int RoleId { get; set; }
        public object Role { get; internal set; }
    }
}
