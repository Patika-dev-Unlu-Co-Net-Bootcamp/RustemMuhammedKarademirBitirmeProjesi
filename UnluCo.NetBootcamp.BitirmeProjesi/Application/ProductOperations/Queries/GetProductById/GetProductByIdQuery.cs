using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.NetBootcamp.BitirmeProjesi.DBOperations;
using UnluCo.NetBootcamp.BitirmeProjesi.Models;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Application.ProductOperations.Queries.GetProductsById
{
    public class GetProductByIdQuery
    {
        public int productId { get; set; }
        private readonly FinalProjectDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetProductByIdQuery(FinalProjectDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public ProductsViewModel Handle()
        {
            var product = _dbContext.Products.Include(p => p.Category).Include(p => p.Brand).
                Include(p => p.Color).Include(p => p.UseState).SingleOrDefault(p=>p.Id==productId);
            if (product is null)
                throw new InvalidOperationException("Ürün sistemde kayıtlı değil!");
            ProductsViewModel productVM = _mapper.Map<ProductsViewModel>(product);
            return productVM;
        }
    }
}
