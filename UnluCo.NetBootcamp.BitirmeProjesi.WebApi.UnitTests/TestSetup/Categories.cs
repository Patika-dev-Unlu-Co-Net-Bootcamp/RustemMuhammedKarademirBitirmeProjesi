using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.NetBootcamp.BitirmeProjesi.DBOperations;
using UnluCo.NetBootcamp.BitirmeProjesi.Entities;

namespace UnluCo.NetBootcamp.BitirmeProjesi.WebApi.UnitTests.TestSetup
{
    public static class Categories
    {
        public static void AddCategories(this FinalProjectDbContext context)
        {
            context.Categories.AddRange(
                new Category
                {
                    Id =1,
                    CategoryName = "Mont"
                },
                new Category
                {
                    Id = 2,
                    CategoryName = "Şapka"
                }
            );
        }
    }
}
