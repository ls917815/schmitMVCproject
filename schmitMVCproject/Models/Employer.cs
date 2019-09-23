using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace schmitMVCproject.Models
{
    public class Employer
    {
        
        public int employerID { get; set; }

        public string employerName { get; set; }

        //public string lastName { get; set; }

        public string phone { get; set; }

        public string email { get; set; }

        //public DateTime customerSince { get; set; }

        //a customer can have any number of orders, 1:M relationship
        // represented in the model with an ICollection
        //syntax says we are creating an ICollection of Order objects
        // (the name inside the <> is the object name
        //local name of the collection will be order
        //(object and local names do not have to be the same

        public ICollection<Employee> Employee { get; set; }

    }
}