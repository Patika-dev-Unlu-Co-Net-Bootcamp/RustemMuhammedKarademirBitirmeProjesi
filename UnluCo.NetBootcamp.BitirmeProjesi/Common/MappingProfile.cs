using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.NetBootcamp.BitirmeProjesi.Entities;
using UnluCo.NetBootcamp.BitirmeProjesi.Models;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserForRegisterModel, User>();
            CreateMap<UserForLoginModel, User>();
            CreateMap<CreateProductModel, Product>();
            CreateMap<CreateCategoryModel, Category>();
            CreateMap<CreateOfferModel, Offer>();
            CreateMap<UpdateProductModel, Product>();
            CreateMap<UpdateCategoryModel, Category>();
            CreateMap<UpdateOfferModel, Offer>();
            CreateMap<Offer, OffersViewModel>();
            CreateMap<Category, CategoriesViewModel>();
            CreateMap<Product, ProductsViewModel>().ForMember(dest => dest.Brand,
                opt => opt.MapFrom(src => src.Brand.BrandName)).ForMember(dest => dest.Color,
                opt => opt.MapFrom(src => src.Color.ColorName)).ForMember(dest => dest.Category,
                opt => opt.MapFrom(src => src.Category.CategoryName)).ForMember(dest => dest.UseState,
                opt => opt.MapFrom(src => src.UseState.State));
        }
    }
}
