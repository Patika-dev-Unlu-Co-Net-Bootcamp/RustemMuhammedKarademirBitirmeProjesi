using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Models
{
    public class CreateOfferModel : IModel
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int OfferedPrice { get; set; }
    }
}
