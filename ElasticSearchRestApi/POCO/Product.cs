using Nest;

namespace ElasticSearchPOC.POCO
{
    public class Product
    {

        public int id { get; set; }
        public string? Name { get; set; }
        public string? ProductNumber { get; set; }
        public string? Color { get; set; }
        public decimal? StandardCost { get; set; }
        public decimal? ListPrice { get; set; }
        public string? Size { get; set; }

        public decimal? Weight { get; set; }
    }
}
