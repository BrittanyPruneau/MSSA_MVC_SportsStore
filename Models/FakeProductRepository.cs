using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class FakeProductRepository: IProductRepository // implements the interface
    {
        public IQueryable<Product> GetAllProducts() // once this class writes the GetAllProducts() method that the interface IMPLEMENTS. 
        {
            Product[] products = new Product[3];

            products[0] = new Product   // HOW OBJECT ARRAY IS CREATED 
            {
                Name = "Football",
                Price = 25
            };
            // OR LIKE THIS: 
            // products[0] = new Product {Name ="Football", Price = 25};
            // creating an array of objects requires NEW every time. 

            products[1] = new Product
            {
                Name = "Surf Board",
                Price = 179
            };

            products[2] = new Product
            {
                Name = "Running Shoes",
                Price = 95,
                Description = "Very fast"
                
            };

            return products.AsQueryable<Product>();  


        } // end GetAllProducts( )

    }
}
