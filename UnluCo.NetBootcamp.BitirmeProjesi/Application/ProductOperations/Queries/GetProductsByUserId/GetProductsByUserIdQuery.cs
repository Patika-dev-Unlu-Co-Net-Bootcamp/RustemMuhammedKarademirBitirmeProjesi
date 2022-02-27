using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.NetBootcamp.BitirmeProjesi.DBOperations;
using UnluCo.NetBootcamp.BitirmeProjesi.Models;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Application.ProductOperations.Queries.GetProductsByUserId
{
    public class GetProductsByUserIdQuery
    {
        public int userId { get; set; }
        private readonly FinalProjectDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetProductsByUserIdQuery(FinalProjectDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public List<ProductsViewModel> Handle()
        {
            var productList = _dbContext.Products.Include(p => p.Category).Include(p => p.Brand).
                Include(p => p.Color).Include(p => p.UseState).Where(p => p.UserId == userId).ToList();
            if (productList is null)
                throw new InvalidOperationException("Ürün sistemde kayıtlı değil!");
            List<ProductsViewModel> productListVM = _mapper.Map<List<ProductsViewModel>>(productList);
            return productListVM;
        }
    }
}
