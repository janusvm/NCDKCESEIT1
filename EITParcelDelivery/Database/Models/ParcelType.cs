using System.Runtime.InteropServices;

namespace EITParcelDelivery.Models
{
    public class ParcelType
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public bool Supported { get; set; }

        public int Fee { get; set; }
    }
}