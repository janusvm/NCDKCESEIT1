using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EITParcelDelivery.Models
{
    public class User
    {

        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public int CityId { get; set; }
    }
}