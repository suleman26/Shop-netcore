﻿using AutoMapper;
using dutch_retreat.Data;
using dutch_retreat.ModelViews;
using DutchTreat.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dutch_retreat.Controllers
{
    [Route("api/{Controller}")]
    public class OrdersController : Controller
    {
        private readonly IDutchRepository _repository;
        private readonly ILogger<OrdersController> _logger;
        private readonly IMapper _mapper;

        public OrdersController(IDutchRepository repository, ILogger<OrdersController> logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult Get(bool includeItems = true)
        {
            try
            {
                var order = _repository.GetAllOrders(includeItems);
                return Ok(_mapper.Map<IEnumerable<Order>, IEnumerable<OrderModelView>>(order));
            }
            catch(Exception ex)
            {
                _logger.LogError($"Unable to get orders: {ex}");
                return BadRequest("Unable to get orders");
            }
            
                

        }
        [HttpGet("{id:int}")]
        public ActionResult Get(int id)
        {
            try
            {
                var order = _repository.GetOrderById(id);
                if (order != null) return Ok(_mapper.Map<Order, OrderModelView>(order));
                else return NotFound();
            }
            catch(Exception ex)
            {
                _logger.LogError($"Unable to get order by id: {ex}");
                return BadRequest("Failed to get order by id");
            }
           
        }
      
        [HttpPost]
        public IActionResult Post([FromBody]OrderModelView model)
        {
            if (ModelState.IsValid)
            {
                var newOrder = _mapper.Map<OrderModelView, Order>(model);
                
                 try
                {
                    if (newOrder.OrderDate == DateTime.MinValue)
                    {
                        newOrder.OrderDate = DateTime.Now;
                    }
                    _repository.AddEntity(newOrder);
                   
                    if (_repository.SaveAll())
                    {
                        return Created($"/api/orders/{newOrder.Id}", _mapper.Map<Order,OrderModelView>(newOrder));
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError($"Failed to save order: {ex}");
                }
            }

                return BadRequest(ModelState);              
        }

    }
}
