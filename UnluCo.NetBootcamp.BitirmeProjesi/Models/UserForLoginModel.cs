using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Models
{
    public class UserForLoginModel : IModel
    {
        [Required(ErrorMessage = "Email boş bırakılamaz.")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre boş bırakılamaz.")]
        [MinLength(8,ErrorMessage = "Şifre en az 8 karakter olmalı.")]
        [MaxLength(20, ErrorMessage = "Şifre en fazla 20 karakter olmalı.")]
        public string Password { get; set; }
    }
}
