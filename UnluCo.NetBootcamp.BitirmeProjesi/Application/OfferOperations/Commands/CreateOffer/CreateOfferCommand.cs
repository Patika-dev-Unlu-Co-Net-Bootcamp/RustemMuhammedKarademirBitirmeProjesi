using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.NetBootcamp.BitirmeProjesi.DBOperations;
using UnluCo.NetBootcamp.BitirmeProjesi.Entities;
using UnluCo.NetBootcamp.BitirmeProjesi.Models;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Application.OfferOperations.Commands.CreateOffer
{
    public class CreateOfferCommand
    {
        public CreateOfferModel Model { get; set; }
        private readonly FinalProjectDbContext _dbContext;
        private readonly IMapper _mapper;
        public CreateOfferCommand(FinalProjectDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public void Handle()
        {
            var product = _dbContext.Products.SingleOrDefault(p => p.Id == Model.ProductId );
            if (product is null)
                throw new InvalidOperationException("Teklif verilen ürün sistemde kayıtlı değil!");
            if (product.Price <= Model.OfferedPrice)//teklif urun bedelinden yuksek veya esitse 
            {
                product.UserId = Model.UserId;//urunun yeni sahibi teklif veren user olur
                product.IsSold = true;
                product.IsOfferable = false;
            }
            var offer = _mapper.Map<Offer>(Model); //Model ile gelen bilgileri Offer nesnesine map et/esle. 
            offer.IsAccept = true;
            _dbContext.Offers.Add(offer);
            _dbContext.SaveChanges();
        }
    }
}
