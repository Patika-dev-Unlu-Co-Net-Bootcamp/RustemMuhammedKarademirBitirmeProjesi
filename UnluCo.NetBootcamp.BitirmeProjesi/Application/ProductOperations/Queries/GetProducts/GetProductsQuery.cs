using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.NetBootcamp.BitirmeProjesi.DBOperations;
using UnluCo.NetBootcamp.BitirmeProjesi.Models;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Application.ProductOperations.Queries.GetProducts
{
    public class GetProductsQuery
    {
        private readonly FinalProjectDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetProductsQuery(FinalProjectDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public List<ProductsViewModel> Handle()
        {
            var productList = _dbContext.Products.Include(p => p.Category).Include(p => p.Brand).
                Include(p => p.Color).Include(p => p.UseState).OrderBy(p => p.Id).Where(p=>p.IsOfferable == true).ToList();
            List<ProductsViewModel> viewModelList = _mapper.Map<List<ProductsViewModel>>(productList);
            return viewModelList;
        }
    }
}
