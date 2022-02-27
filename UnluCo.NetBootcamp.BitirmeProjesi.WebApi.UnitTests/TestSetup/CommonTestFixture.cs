using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.NetBootcamp.BitirmeProjesi.Common;
using UnluCo.NetBootcamp.BitirmeProjesi.DBOperations;

namespace UnluCo.NetBootcamp.BitirmeProjesi.WebApi.UnitTests.TestSetup
{
    public class CommonTestFixture
    {
        public FinalProjectDbContext Context { get; set; }
        public IMapper Mapper { get; set; }
        public CommonTestFixture()
        {
            var options = new DbContextOptionsBuilder<FinalProjectDbContext>().UseInMemoryDatabase(databaseName: "FinalProjectTestDB").Options;
            Context = new FinalProjectDbContext(options);//kendi olusturdugumuz optionslari verdik
            Context.Database.EnsureCreated();//Database olustugunu test etmek icin
            Context.AddCategories();
            Context.SaveChanges();

            Mapper = new MapperConfiguration(cfg => { cfg.AddProfile<MappingProfile>(); }).CreateMapper();//Proje icerisinde mapping islemlerindeki degisiklikleri alabilmek icin senkronize ettik
        }
    }
}
