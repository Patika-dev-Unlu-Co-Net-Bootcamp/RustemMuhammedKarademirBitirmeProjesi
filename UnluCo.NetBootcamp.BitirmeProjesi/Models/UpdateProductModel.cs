using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Models
{
    public class UpdateProductModel : IModel
    {
        public string ImagePath { get; set; }
        public int Price { get; set; }
        public bool IsImageDelete { get; set; }
    }
}