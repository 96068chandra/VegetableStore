using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VegetableStore.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Qunatity { get; set; }
        public int TotalPrice { get; set; }
        public int Discount { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public Packsize Packsize { get; set; }
        public int PackId { get; set; }


    }
}