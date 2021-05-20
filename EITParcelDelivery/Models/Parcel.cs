using System;
using System.Runtime.InteropServices;

namespace EITParcelDelivery.Models
{
    public class Parcel
    {
        public int Id { get; set; }

        public ParcelType Type { get; set; }

        public int Price { get; set; }

        public int weight { get; set; }

        public DateTime ETA { get; set; }

        public City Start { get; set; }

        public Enums.ParcelStatus Status { get; set; }

    }
}