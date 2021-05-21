using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace EITParcelDelivery.Models
{
    public class SendParcelViewModel
    {
        [Required]
        [Range(0, 100)]
        [DisplayName("Weight (in kg)")]
        public int Weight { get; set; }

        [Required]
        public City Source { get; set; }

        [Required]
        public City Destination { get; set; }

        [Required]
        public ParcelType Type { get; set; }

        public List<City> Cities { get; set; }

        public IEnumerable<string> getCityNames()
        {
            return Cities.Where(c => c.Available).Select(c => c.name);
        }
    }
}