using System;

namespace EITParcelDelivery.Models
{
    public class PathComponent
    {
        public int Id { get; set; }

        public City City { get; set; }

        public PathComponent NextDestination { get; set; }

        public DateTime? ArrivedAt { get; set; }
    }
}