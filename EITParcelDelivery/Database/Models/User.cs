namespace EITParcelDelivery.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public City City { get; set; }

        public Enums.Role Role { get; set; }
    }
}