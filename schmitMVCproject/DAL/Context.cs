using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using schmitMVCproject.Models; //this is needed to access the models
using System.Data.Entity; //this is needed to access the DbContext object

namespace schmitMVCproject.DAL
{
    public class Context : DbContext //inherits from DbContext
    {
        public Context() : base ("name = DefaultConnection")
        {
            //this method is a 'constructor' and is called when a new context is created
            //the base attribute says which connection string to use
        }

        //include each object here. The value inside <> is the name of the class
        //the value outside should generally be the plural of the class name
        //and is the name used to reference the entity in code

        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}