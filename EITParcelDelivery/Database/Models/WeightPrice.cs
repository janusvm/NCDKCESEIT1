using System.Runtime.InteropServices;

namespace EITParcelDelivery.Models
{
    public class WeightPrice
    {
        public int Id { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }

        public double Price { get; set; }
    }
}