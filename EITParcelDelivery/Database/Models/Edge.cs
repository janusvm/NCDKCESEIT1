namespace EITParcelDelivery.Models
{
    public class Edge
    {
        public int Id { get; set; }

        public City Source { get; set; }

        public City Destination { get; set; }

        public int Segments { get; set; }
    }
}