using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.NetBootcamp.BitirmeProjesi.DBOperations;
using UnluCo.NetBootcamp.BitirmeProjesi.Entities;
using UnluCo.NetBootcamp.BitirmeProjesi.Models;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Application.CategoryOperations.Commands.CreateCategory
{
    public class CreateCategoryCommand
    {
        public CreateCategoryModel Model { get; set; }
        private readonly FinalProjectDbContext _dbContext;
        private readonly IMapper _mapper;
        public CreateCategoryCommand(FinalProjectDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public void Handle()
        {
            var category = _dbContext.Categories.SingleOrDefault(c => c.CategoryName == Model.CategoryName);
            if (category is not null)
                throw new InvalidOperationException("Kategori sistemde kayıtlı!");
            category = _mapper.Map<Category>(Model); //Model ile gelen bilgileri Category nesnesine map et/esle. 
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
        }
    }
}
