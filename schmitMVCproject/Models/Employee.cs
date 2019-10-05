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

        [Display (Name ="First name")]
        [Required(ErrorMessage ="Employee first name is required")]
        [StringLength(20)]
        public string firstName { get; set; }

        [Display(Name = "Last name")]
        [Required(ErrorMessage = "Employee last name is required")]
        [StringLength(20)]
        public string lastName { get; set; }

        [Display(Name = "Department name")]
        [Required(ErrorMessage = "Employee department name is required")]
        [StringLength(20)]
        public string department { get; set; }

        //order is on the one side of 1:M relationship with OrderDetail
        //indicated by ICollection

        //public ICollection<OrderDetail> OrderDetail { get; set; }

        public int employerID { get; set; }

        public virtual Employer Employers { get; set; }

        public ICollection<Client> Clients { get; set; }
    }
}