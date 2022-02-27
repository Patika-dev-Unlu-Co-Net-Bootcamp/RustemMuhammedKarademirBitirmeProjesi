using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.NetBootcamp.BitirmeProjesi.DBOperations;
using UnluCo.NetBootcamp.BitirmeProjesi.Models;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Application.OfferOperations.Commands.UpdateOffer
{
    public class UpdateOfferCommand
    {
        public UpdateOfferModel Model { get; set; }
        private readonly FinalProjectDbContext _dbContext;
        public int offerId { get; set; }
        public UpdateOfferCommand(FinalProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Handle()
        {
            var offer = _dbContext.Offers.Find(offerId);
            var product = _dbContext.Products.SingleOrDefault(p => p.Id == offer.ProductId);
            if (offer is null)
                throw new InvalidOperationException("Teklif sistemde kayıtlı değil!");
            offer.IsAccept = Model.IsAccept;
            offer.IsAnswer = true;
            if(offer.IsAccept)
                product.UserId =offer.UserId;
            _dbContext.SaveChanges();
        }
    }
}
