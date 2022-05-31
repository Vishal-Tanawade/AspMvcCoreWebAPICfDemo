using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMvcCoreWebAPICfDemo.Models
{
    public static  class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                
                new Product() { ProductCode=101,ProductName="Speaker",ProductPrice=30000.00m},
                new Product() { ProductCode = 102, ProductName = "Desktop", ProductPrice = 30000.00m }, 
                new Product() { ProductCode = 103, ProductName = "Laptops", ProductPrice = 25000.00m }, 
                new Product() { ProductCode = 104, ProductName = "Gaming Pc's", ProductPrice = 60000.00m }, 
                new Product() { ProductCode = 105, ProductName = "Servers", ProductPrice = 100000.00m }, new Product() { ProductCode = 106, ProductName = "Tablets", ProductPrice = 5000.00m }



                );
        }
    }
}
