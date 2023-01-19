using Nest;

namespace ElasticSearchPOC.POCO
{
    public class Product
    {
       
        public int ProductID { get; set; }
        public string ?Name { get; set; }
        public string ?ProductNumber { get; set; }
        public string ?Color { get; set; }
        public decimal ?StandardCost { get; set; }
        public decimal ?ListPrice { get; set; }
        public int ?Size { get; set; }
         
        public int Weight { get; set; }
    }
}
