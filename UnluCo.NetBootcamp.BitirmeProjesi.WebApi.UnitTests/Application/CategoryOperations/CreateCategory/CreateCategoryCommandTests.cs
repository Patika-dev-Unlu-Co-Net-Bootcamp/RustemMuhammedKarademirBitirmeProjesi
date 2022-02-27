using AutoMapper;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.NetBootcamp.BitirmeProjesi.Application.CategoryOperations.Commands.CreateCategory;
using UnluCo.NetBootcamp.BitirmeProjesi.DBOperations;
using UnluCo.NetBootcamp.BitirmeProjesi.Entities;
using UnluCo.NetBootcamp.BitirmeProjesi.Models;
using UnluCo.NetBootcamp.BitirmeProjesi.WebApi.UnitTests.TestSetup;
using Xunit;

namespace UnluCo.NetBootcamp.BitirmeProjesi.WebApi.UnitTests.Application.CategoryOperations.CreateCategory
{
    public class CreateCategoryCommandTests : IClassFixture<CommonTestFixture>
    {
        private readonly FinalProjectDbContext _context;
        private readonly IMapper _mapper;
        public CreateCategoryCommandTests(CommonTestFixture testFixture)
        {
            _context = testFixture.Context;
            _mapper = testFixture.Mapper;
        }
        [Fact]
        public void WhenAlreadyExistCategoryNameIsGiven_InvalidOperationExeption_ShouldBeReturn()//sistemde kayitli bir kategori eklenmeye calisirsa IOE firlatmali
        {
            //arrange - Hazirlik
            var category = new Category() {CategoryName = "Test_WhenAlreadyExistCategoryNameIsGiven_InvalidOperationExeption_ShouldBeReturn"};
            _context.Categories.Add(category);
            _context.SaveChanges();

            CreateCategoryCommand command = new CreateCategoryCommand(_context, _mapper);
            command.Model = new CreateCategoryModel() { CategoryName=category.CategoryName};
            //act - Calistirma && assert - Dogrulama
            FluentActions.Invoking(() => command.Handle()).
                Should().Throw<InvalidOperationException>().And.Message.Should().Be("Kategori sistemde kayıtlı!");
        }
        [Fact]
        public void WhenValidInputsAreGiven_Validator_ShouldBeCreated()
        {
            //arrange
            CreateCategoryCommand command = new CreateCategoryCommand(_context, _mapper);
            CreateCategoryModel model = new CreateCategoryModel() { CategoryName="Kategori" };
            command.Model = model;

            //act
            FluentActions.Invoking(() => command.Handle()).Invoke();//Should().Be() islemi yapilmaz ise Invoke ile calistirilmali

            //assert
            var category = _context.Categories.SingleOrDefault(c => c.CategoryName == model.CategoryName);
            category.Should().NotBeNull();//book null olamaz
            category.CategoryName.Should().Be(model.CategoryName);//category CategoryName degeri model CategoryName degerine esit olmali
        }
    }
}
