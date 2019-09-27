using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace schmitMVCproject.Models
{
    public class Employee
    {
        [Key]
        public int employeeID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string department { get; set; }

        //order is on the one side of 1:M relationship with OrderDetail
        //indicated by ICollection

        //public ICollection<OrderDetail> OrderDetail { get; set; }

        public int employerID { get; set; }

        public virtual Employer Employers { get; set; }

        public ICollection<Client> Clients { get; set; }
    }
}