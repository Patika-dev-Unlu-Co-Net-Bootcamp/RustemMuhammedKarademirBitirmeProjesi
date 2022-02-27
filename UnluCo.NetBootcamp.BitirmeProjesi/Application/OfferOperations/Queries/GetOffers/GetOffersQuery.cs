using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.NetBootcamp.BitirmeProjesi.DBOperations;
using UnluCo.NetBootcamp.BitirmeProjesi.Models;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Application.OfferOperations.Queries.GetOffers
{
    public class GetOffersQuery
    {
        private readonly FinalProjectDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetOffersQuery(FinalProjectDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public List<OffersViewModel> Handle()
        {
            var offerList = _dbContext.Offers.OrderBy(o => o.Id).ToList();
            List<OffersViewModel> viewModelList = _mapper.Map<List<OffersViewModel>>(offerList);
            return viewModelList;
        }
    }
}
