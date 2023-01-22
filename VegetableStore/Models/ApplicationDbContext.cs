using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VegetableStore.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext():base("MyCon")
        {

        }
        public DbSet<Products> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Packsize> Packsize { get; set; }


    }
}