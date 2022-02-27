using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Models
{
    public class CreateCategoryModel :IModel
    {
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public string CategoryName { get; set; }
    }
}
