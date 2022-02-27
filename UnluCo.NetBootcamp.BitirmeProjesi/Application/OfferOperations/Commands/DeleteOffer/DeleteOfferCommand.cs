using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.NetBootcamp.BitirmeProjesi.DBOperations;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Application.OfferOperations.Commands.DeleteOffer
{
    public class DeleteOfferCommand
    {
        private readonly FinalProjectDbContext _dbContext;
        public int offerId { get; set; }
        public DeleteOfferCommand(FinalProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Handle()
        {
            var offer = _dbContext.Offers.Find(offerId);
            if (offer is null)
                throw new InvalidOperationException("Teklif sistemde kayıtlı değil!");
            _dbContext.Offers.Remove(offer);
            _dbContext.SaveChanges();
        }
    }
}
