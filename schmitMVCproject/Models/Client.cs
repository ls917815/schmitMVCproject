using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace schmitMVCproject.Models
{
    public class Client
    {
        public System.Guid guid { get; set; }

        public int clientID { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Address is required")]
        [StringLength(50)]  
        public string address { get; set; }

        [Display(Name = "Client Description")]
        [Required(ErrorMessage = "Description is required")]
        [StringLength(50)]
        public string description { get; set; }

        //link client to employer
        public int employerID { get; set; }
        public virtual Employer Employer { get; set; }

        //link client to employee
        public int employeeID { get; set; }
        public virtual Employee Employee { get; set; }
    }
}