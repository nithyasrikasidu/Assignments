using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HOL_Demo.Models
{
    public class Product
    {
       
public int ProductId { get; set; }

        public string ProductName { get; set; }

        public double Price { get; set; }

        public IEnumerable<Product> GetProducts()

        {

            return new List<Product>()

 {

                  new Product{ProductId=1,

                 ProductName="Milk",Price=600},
                  
                  new Product{ProductId=2,

                  ProductName="bag",Price=500},

                  new Product{ProductId=3,

                  ProductName="Mobile",Price=15000},

 

 };

        }


    }
}