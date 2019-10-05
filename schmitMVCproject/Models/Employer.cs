using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace schmitMVCproject.Models
{
    public class Employer
    {
        
        public int employerID { get; set; }

       [DisplayName("Employer Name")]
       [Required]
       [StringLength(20)]
        public string employerName { get; set; }

        //public string lastName { get; set; }

        [Display (Name ="Phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$",
            ErrorMessage ="Phone numbers must be in format xxx-xxx-xxxx")]
        public string phone { get; set; }

        [Display (Name ="Email Address")]
        [Required]
        [EmailAddress(ErrorMessage ="Please enter an email address")]
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