using AutoMapper;
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
    [Route("/api/orders/{orderid}/items")]
    public class OrderItemsController : Controller
    {
        private readonly IDutchRepository _repository;
        private readonly ILogger<OrderItemsController> _logger;
        private readonly IMapper _mapper;

        public OrderItemsController(IDutchRepository repository, ILogger<OrderItemsController> logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public ActionResult Get(int orderId)
        {
            var order = _repository.GetOrderById(orderId);
            if (order!= null) return Ok(_mapper.Map<IEnumerable<OrderItem>, IEnumerable<OrderItemModelView>>(order.Items));
            return BadRequest();

        }
        [HttpGet("{id}")]
        public ActionResult Get(int orderId, int id)
        {
            var order = _repository.GetOrderById(orderId);
            if (order != null) 
            {
                var item = order.Items.Where(i => i.Id == id).FirstOrDefault();
                if (item != null)
                {
                    return Ok(_mapper.Map<OrderItem, OrderItemModelView>(item));
                }

                else
                {
                    return NotFound();
                }
               
            }

            else
            {
                return NotFound();
            }
           
           
        }

    }
}
