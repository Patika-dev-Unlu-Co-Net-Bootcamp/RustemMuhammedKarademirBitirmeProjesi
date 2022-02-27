using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.NetBootcamp.BitirmeProjesi.DBOperations;
using UnluCo.NetBootcamp.BitirmeProjesi.Entities;
using UnluCo.NetBootcamp.BitirmeProjesi.Models;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Application.ProductOperations.Commands.CreateProduct
{
    public class CreateProductCommand
    {
        public CreateProductModel Model { get; set; }
        private readonly FinalProjectDbContext _dbContext;
        private readonly IMapper _mapper;
        public CreateProductCommand(FinalProjectDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public void Handle()
        {
            var product = _dbContext.Products.SingleOrDefault(p => p.ProductName == Model.ProductName && p.BrandId == Model.BrandId);
            if (product is not null)
                throw new InvalidOperationException("Ürün sistemde kayıtlı!");
            product = _mapper.Map<Product>(Model); //Model ile gelen bilgileri Product nesnesine map et/esle. 
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }
    }
}
