using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.NetBootcamp.BitirmeProjesi.DBOperations;
using UnluCo.NetBootcamp.BitirmeProjesi.Models;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Application.ProductOperations.Commands.UpdateProduct
{
    public class UpdateProductCommand
    {
        public UpdateProductModel Model { get; set; }
        private readonly FinalProjectDbContext _dbContext;
        private readonly IMapper _mapper;
        public int productId { get; set; }
        public UpdateProductCommand(FinalProjectDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public void Handle()
        {
            var product = _dbContext.Products.SingleOrDefault(p => p.Id == productId);
            if (product is null)
                throw new InvalidOperationException("Ürün sistemde kayıtlı değil!");
            if(!Model.IsImageDelete)
                product.ImagePath = string.IsNullOrEmpty(Model.ImagePath) ? product.ImagePath : Model.ImagePath;
            else 
                product.ImagePath = null;
            product.Price = int.Equals(Model.Price, 0) ? product.Price : Model.Price;
            _dbContext.SaveChanges();
        }
    }
}
