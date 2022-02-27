using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.NetBootcamp.BitirmeProjesi.DBOperations;
using UnluCo.NetBootcamp.BitirmeProjesi.Models;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Application.CategoryOperations.Queries.GetCategoryById
{
    public class GetCategoryByIdQuery
    {
        public int categoryId { get; set; }
        private readonly FinalProjectDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetCategoryByIdQuery(FinalProjectDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public List<ProductsViewModel> Handle()
        {
            var category = _dbContext.Categories.Find(categoryId);
            if (category is null)
                throw new InvalidOperationException("Kategori sistemde kayıtlı değil!");
            var productList = _dbContext.Products.Include(p => p.Category).Include(p => p.Brand).
                Include(p => p.Color).Include(p => p.UseState).OrderBy(p => p.ProductName).Where(p => p.CategoryId == categoryId && p.IsOfferable == true).ToList();
            List<ProductsViewModel> productVMList = _mapper.Map<List<ProductsViewModel>>(productList);
            return productVMList;
        }
    }
}
