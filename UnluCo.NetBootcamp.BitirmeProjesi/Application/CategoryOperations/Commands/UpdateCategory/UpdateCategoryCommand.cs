using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.NetBootcamp.BitirmeProjesi.DBOperations;
using UnluCo.NetBootcamp.BitirmeProjesi.Entities;
using UnluCo.NetBootcamp.BitirmeProjesi.Models;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Application.CategoryOperations.Commands.UpdateCategory
{
    public class UpdateCategoryCommand
    {
        public UpdateCategoryModel Model { get; set; }
        public int categoryId { get; set; }
        private readonly FinalProjectDbContext _dbContext;
        public UpdateCategoryCommand(FinalProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Handle()
        {
            var category = _dbContext.Categories.Find(categoryId);
            if (category is null)
                throw new InvalidOperationException("Kategori sistemde kayıtlı değil!");
            category.CategoryName = string.IsNullOrEmpty(Model.CategoryName) ? category.CategoryName : Model.CategoryName;//Modelin CategoryName alani bos ise sistemde kayitli olan veriyi yazar
            _dbContext.SaveChanges();
        }
    }
}
