﻿using ETicaretAPI.Application.Abstraction;
using ETicaretAPI.Application.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
       readonly private IProductWriteRepository _productWriteRepository;
       readonly private IProductReadRepository _productReadRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new() {Id = Guid.NewGuid(), Name = "Product 1", Price = 100, Stock = 10, CreatedDate = DateTime.UtcNow },
                new() {Id = Guid.NewGuid(), Name = "Product 2", Price = 200, Stock = 20, CreatedDate = DateTime.UtcNow },
                new() {Id = Guid.NewGuid(), Name = "Product 3", Price = 300, Stock = 130, CreatedDate = DateTime.UtcNow },
                new() {Id = Guid.NewGuid(), Name = "Product 4", Price = 400, Stock = 200, CreatedDate = DateTime.UtcNow },
            });
            await _productWriteRepository.SaveAsync();
        }
        
    }
}
