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
                
                new Product() { ProductCode=  1,ProductName="Speaker",ProductPrice=30000.00m},
                new Product() { ProductCode = 2, ProductName = "Desktop", ProductPrice = 30000.00m }, 
                new Product() { ProductCode = 3, ProductName = "Laptops", ProductPrice = 25000.00m }, 
                new Product() { ProductCode = 4, ProductName = "Gaming Pc's", ProductPrice = 60000.00m }, 
                new Product() { ProductCode = 5, ProductName = "Servers", ProductPrice = 100000.00m }, 
                new Product() { ProductCode = 6, ProductName = "Tablets", ProductPrice = 5000.00m }



                );
        }
    }
}
