using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Entities
{
    public class Brand :IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string BrandName { get; set; }
    }
}
