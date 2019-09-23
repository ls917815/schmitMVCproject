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

        public ICollection<orderDetail> OrderDetail { get; set; }
    }

    public class orderDetail
    {
        public int orderdetailID { get; set; }
        public int qtyOrdered { get; set; }
        public decimal price { get; set; }

        //next two properties link the orderDetail to the Order
        public int orderID { get; set; }
        public virtual Order Order { get; set; }

        //next two properties link the orderDetail to the Product
        public int productID { get; set; }
        public virtual Product Product {get; set; }
    }
}