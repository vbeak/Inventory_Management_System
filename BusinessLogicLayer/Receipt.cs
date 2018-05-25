using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Receipt
    {
        public int sn {get; set; }
        public int categoryId { get; set; }
        public string categoryname { get; set; }
        public int productId { get; set; }
        public string productName { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
        public decimal total { get; set; }
       
        
    }
}
