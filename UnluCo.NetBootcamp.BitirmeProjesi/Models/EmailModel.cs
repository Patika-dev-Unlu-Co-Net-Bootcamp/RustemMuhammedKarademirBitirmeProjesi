using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Models
{
    public class EmailModel : IModel
    {
        public string Email { get; set; }
        public string Body { get; set; }
    }
}
