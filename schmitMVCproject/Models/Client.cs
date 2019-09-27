using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace schmitMVCproject.Models
{
    public class Client
    {
        public int clientID { get; set; }
        public string address { get; set; }
        public string description { get; set; }

        //link client to employer
        public int employerID { get; set; }
        public virtual Employer Employer { get; set; }

        //link client to employee
        public int employeeID { get; set; }
        public virtual Employee Employee { get; set; }
    }
}