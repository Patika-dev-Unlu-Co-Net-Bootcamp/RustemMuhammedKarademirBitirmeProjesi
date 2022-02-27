using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.NetBootcamp.BitirmeProjesi.Application.ProductOperations.Commands.CreateProduct;
using UnluCo.NetBootcamp.BitirmeProjesi.Application.ProductOperations.Commands.UpdateProduct;
using UnluCo.NetBootcamp.BitirmeProjesi.Application.ProductOperations.Queries.GetProducts;
using UnluCo.NetBootcamp.BitirmeProjesi.Application.ProductOperations.Queries.GetProductsById;
using UnluCo.NetBootcamp.BitirmeProjesi.Application.ProductOperations.Queries.GetProductsByUserId;
using UnluCo.NetBootcamp.BitirmeProjesi.DBOperations;
using UnluCo.NetBootcamp.BitirmeProjesi.Models;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        private readonly FinalProjectDbContext _context;
        private readonly IMapper _mapper;
        public ProductController(FinalProjectDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Get()
        {
            GetProductsQuery query = new GetProductsQuery(_context, _mapper);
            var result = query.Handle();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            GetProductByIdQuery query = new GetProductByIdQuery(_context, _mapper);
            query.productId = id;
            var result = query.Handle();
            return Ok(result);
        }
        [HttpGet]
        [Route("userid/{id}")]
        public IActionResult GetByUserId(int id)
        {
            GetProductsByUserIdQuery query = new GetProductsByUserIdQuery(_context, _mapper);
            query.userId = id;
            var result = query.Handle();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Create([FromBody] CreateProductModel product)
        {
            CreateProductCommand command = new CreateProductCommand(_context, _mapper);
            command.Model = product;
            CreateProductCommandValidator validator = new CreateProductCommandValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok(new ResultModel { Message="Ürün eklendi."});
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id,[FromBody] UpdateProductModel product)
        {
            UpdateProductCommand command = new UpdateProductCommand(_context, _mapper);
            command.productId = id;
            command.Model = product;
            //CreateProductCommandValidator validator = new CreateProductCommandValidator();
            //validator.ValidateAndThrow(command);
            command.Handle();
            return Ok(new ResultModel { Message = "Ürün güncellendi." });
        }
        [HttpGet("forproductadd")]
        public IActionResult GetForProductAdd()
        {
            var brands= _context.Brands.OrderBy(b => b.Id).ToList();
            var categories = _context.Categories.OrderBy(b => b.Id).ToList();
            var colors = _context.Colors.OrderBy(b => b.Id).ToList();
            var useStates = _context.UseStates.OrderBy(b => b.Id).ToList();
            return Ok(new ProductAddPropertyModel {brands=brands,categories=categories,colors=colors,useStates=useStates});
        }
    }
}
