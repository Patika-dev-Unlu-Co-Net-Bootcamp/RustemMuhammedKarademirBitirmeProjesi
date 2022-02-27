using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.NetBootcamp.BitirmeProjesi.Application.CategoryOperations.Commands.CreateCategory;
using UnluCo.NetBootcamp.BitirmeProjesi.Application.CategoryOperations.Commands.UpdateCategory;
using UnluCo.NetBootcamp.BitirmeProjesi.Application.CategoryOperations.Queries.GetCategories;
using UnluCo.NetBootcamp.BitirmeProjesi.Application.CategoryOperations.Queries.GetCategoryById;
using UnluCo.NetBootcamp.BitirmeProjesi.DBOperations;
using UnluCo.NetBootcamp.BitirmeProjesi.Models;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly FinalProjectDbContext _context;
        private readonly IMapper _mapper;
        public CategoryController(FinalProjectDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            GetCategoriesQuery query = new GetCategoriesQuery(_context, _mapper);
            var result = query.Handle();
            return Ok(result);
        }
        [Authorize]
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            GetCategoryByIdQuery query = new GetCategoryByIdQuery(_context, _mapper);
            query.categoryId = id;
            GetCategoryByIdQueryValidator validator = new GetCategoryByIdQueryValidator();
            validator.ValidateAndThrow(query);
            var result = query.Handle();
            return Ok(result);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Create([FromBody] CreateCategoryModel category)
        {
            CreateCategoryCommand command = new CreateCategoryCommand(_context, _mapper);
            command.Model = category;
            CreateCategoryCommandValidator validator = new CreateCategoryCommandValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok(new ResultModel {Message="Kategori eklendi." });
        }
        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateCategoryModel category)
        {
            UpdateCategoryCommand command = new UpdateCategoryCommand(_context);
            command.categoryId = id;
            command.Model = category;
            UpdateCategoryCommandValidator validator = new UpdateCategoryCommandValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok(new ResultModel { Message = "Kategori güncellendi." });
        }
    }
}
