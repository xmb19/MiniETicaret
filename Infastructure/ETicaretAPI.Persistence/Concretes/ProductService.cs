using ETicaretAPI.Application.Abstraction;
using ETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        => new()
        {
            new() { Id = Guid.NewGuid(),Name = "Laptop", Price = 1000, Stock = 10 },
            new () { Id = Guid.NewGuid(), Name = "Phone", Price = 500, Stock = 10 },
            new () { Id = Guid.NewGuid(), Name = "Tablet", Price = 800, Stock = 10 },
            new () { Id = Guid.NewGuid(), Name = "PC", Price = 1500, Stock = 10 },
        };
    };
}

