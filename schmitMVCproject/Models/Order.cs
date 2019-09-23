using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace schmitMVCproject.Models
{
    public class Order
    {

        public int orderID { get; set; }
        public string description { get; set; }
        public DateTime orderDate { get; set; }

        //order is on the one side of 1:M relationship with OrderDetail
        //indicated by ICollection

        public ICollection<orderDetail> OrderDetail { get; set; }

        public int customerID { get; set; }

        public virtual Customer customer { get; set; }

    }


}