using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.NetBootcamp.BitirmeProjesi.DBOperations;
using UnluCo.NetBootcamp.BitirmeProjesi.Models;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Application.CategoryOperations.Queries.GetCategories
{
    public class GetCategoriesQuery
    {
        private readonly FinalProjectDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetCategoriesQuery(FinalProjectDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public List<CategoriesViewModel> Handle()
        {
            var categoryList = _dbContext.Categories.OrderBy(c => c.Id).ToList();
            List<CategoriesViewModel> viewModelList = _mapper.Map<List<CategoriesViewModel>>(categoryList);
            return viewModelList;
        }
    }
}
