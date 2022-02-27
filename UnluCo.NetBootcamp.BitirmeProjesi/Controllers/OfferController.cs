using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.NetBootcamp.BitirmeProjesi.Application.OfferOperations.Commands.CreateOffer;
using UnluCo.NetBootcamp.BitirmeProjesi.Application.OfferOperations.Commands.DeleteOffer;
using UnluCo.NetBootcamp.BitirmeProjesi.Application.OfferOperations.Commands.UpdateOffer;
using UnluCo.NetBootcamp.BitirmeProjesi.Application.OfferOperations.Queries.GetOffers;
using UnluCo.NetBootcamp.BitirmeProjesi.Application.OfferOperations.Queries.GetOffersByProductId;
using UnluCo.NetBootcamp.BitirmeProjesi.Application.OfferOperations.Queries.GetOffersByUserId;
using UnluCo.NetBootcamp.BitirmeProjesi.DBOperations;
using UnluCo.NetBootcamp.BitirmeProjesi.Models;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class OfferController : ControllerBase
    {
        private readonly FinalProjectDbContext _context;
        private readonly IMapper _mapper;
        public OfferController(FinalProjectDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Get()
        {
            GetOffersQuery query = new GetOffersQuery(_context, _mapper);
            var result = query.Handle();
            return Ok(result);
        }
        [HttpGet]
        [Route("productid/{id}")]
        public IActionResult GetByProductId(int id)
        {
            GetOffersByProductIdQuery query = new GetOffersByProductIdQuery(_context, _mapper);
            query.productId = id;
            var result = query.Handle();
            return Ok(result);
        }
        [HttpGet]
        [Route("userid/{id}")]
        public IActionResult GetByUserId(int id)
        {
            GetOffersByUserIdQuery query = new GetOffersByUserIdQuery(_context, _mapper);
            query.userId = id;
            var result = query.Handle();
            return Ok(result);
        }
        [HttpPost] 
        public IActionResult Create([FromBody] CreateOfferModel offer)
        {
            CreateOfferCommand command = new CreateOfferCommand(_context, _mapper);
            command.Model = offer;
            CreateOfferCommandValidator validator = new CreateOfferCommandValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok(new ResultModel {Message="Teklif verildi." } );
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateOfferModel offer)
        {
            UpdateOfferCommand command = new UpdateOfferCommand(_context);
            command.offerId = id;
            command.Model = offer;
            command.Handle();
            if(offer.IsAccept)
                return Ok(new ResultModel { Message = "Teklif onaylandı." });
            else
                return Ok(new ResultModel { Message = "Teklif reddedildi." });
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            DeleteOfferCommand command = new DeleteOfferCommand(_context);
            command.offerId = id;
            DeleteOfferCommandValidator validator = new DeleteOfferCommandValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok(new ResultModel { Message = "Teklif iptal edildi." });
        }
    }
}
