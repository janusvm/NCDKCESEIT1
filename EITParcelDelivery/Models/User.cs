namespace EITParcelDelivery.Models
{
    public class User
    {
        public int Id { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public City City { get; set; }

        public Enums.Role Role { get; set; }
    }
}