using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Models
{
    public class OffersViewModel:IModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int OfferedPrice { get; set; }
        public bool IsAccept { get; set; }
        public bool IsAnswer { get; set; }
    }
}
