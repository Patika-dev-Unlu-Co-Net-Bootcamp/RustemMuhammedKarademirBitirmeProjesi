using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.NetBootcamp.BitirmeProjesi.DBOperations;
using UnluCo.NetBootcamp.BitirmeProjesi.Models;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Application.OfferOperations.Queries.GetOffersByProductId
{
    public class GetOffersByProductIdQuery
    {
        public int productId { get; set; }
        private readonly FinalProjectDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetOffersByProductIdQuery(FinalProjectDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public List<OffersViewModel> Handle()
        {
            var offerList = _dbContext.Offers.OrderBy(o => o.Id).Where(o => o.ProductId == productId && o.IsAnswer==false).ToList();
            List<OffersViewModel> viewModelList = _mapper.Map<List<OffersViewModel>>(offerList);
            return viewModelList;
        }
    }
}
