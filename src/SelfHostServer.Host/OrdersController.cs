using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHostServer.Host
{
    public class OrdersController : ApiController
    {
        Order[] orders = new Order[] { 
        new Order { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1},
        new Order { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M},
        new Order { Id = 3, Name = "Hammer", Category = "Hard ware", Price = 16.9M}
        };

        public IEnumerable<Order> getallorder()
        {
            return orders;
        }


    }


    public class ProductsController : ApiController
    {
        Product[] products = new Product[] {
        new Product { Id = 1, Name = "Product1"},
        new Product { Id = 2, Name = "Product2"},
        new Product { Id = 3, Name = "Product3"}
        };

        [HttpGet]
        public IEnumerable<Product> all()
        {
            return products;
        }


    }
}

public class Order
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public Decimal Price { get; set; }
}


public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
}
