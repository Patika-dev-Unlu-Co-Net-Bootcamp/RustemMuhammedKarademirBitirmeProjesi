using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Models
{
    public class CreateProductModel :IModel
    {
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [MaxLength(100, ErrorMessage = "Ürün adı 100 karakterden fazla olamaz.")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public int BrandId { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public int ColorId { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public int UseStateId { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [MaxLength(500,ErrorMessage = "Açıklama 500 karakterden fazla olamaz.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Ürün Fotoğrafı eklemediniz.")]
        //[MaxFileSize(5 * 1024 * 1024)]
        //[AllowedExtensions(new string[] { ".jpg", ".png" })]
        public string ImagePath { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public int Price { get; set; }
        public bool IsSold { get; set; } = false;
        public bool IsOfferable { get; set; }
    }
}
