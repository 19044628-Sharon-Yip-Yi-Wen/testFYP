using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace testFYP.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int StockAvailable { get; set; }
        //Image  ProductPicture  { get; set; }
        public int CategoryId { get; set; }

}
}
