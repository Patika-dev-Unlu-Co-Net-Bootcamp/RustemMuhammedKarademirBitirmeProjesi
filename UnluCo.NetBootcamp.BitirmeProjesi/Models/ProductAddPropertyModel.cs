using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.NetBootcamp.BitirmeProjesi.Entities;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Models
{
    public class ProductAddPropertyModel:IModel
    {
        public List<Brand> brands { get; set; }
        public List<Category> categories { get; set; }
        public List<Color> colors { get; set; }
        public List<UseState> useStates { get; set; }
    }
}
