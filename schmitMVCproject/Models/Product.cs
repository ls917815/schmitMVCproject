using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace schmitMVCproject.Models
{
    public class Product
    {
        public int productID { get; set; }
        public string description { get; set; }
        public string unitCost { get; set; }

        //product is the one side of the one-to-many relationship with OrderDetail
        //we indicate that with an ICollection

        public ICollection<OrderDetail> OrderDetail { get; set; }
    }
}