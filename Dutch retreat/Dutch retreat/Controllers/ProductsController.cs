using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dutch_retreat.Data;
using DutchTreat.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using dutch_retreat.ModelViews;
using AutoMapper;

namespace dutch_retreat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProductsController:Controller
    {
        private readonly IDutchRepository _repository;
        private readonly ILogger<ProductsController> _logger;
        private readonly IMapper _mapper;

        public ProductsController(IDutchRepository repository, ILogger<ProductsController> logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult<IEnumerable<Product>> Get()
        {
            try
            {
                return Ok(_repository.GetAllProducts());
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed ro get products: {ex}");
                return BadRequest("Failed to get products");
            }
        }
        [HttpPost]
        public ActionResult post(Product model)
        {
            if (ModelState.IsValid)
            {
               
                _repository.AddEntity(model);
                if(_repository.SaveAll())
                {
                    var result = _mapper.Map<ProductModelView>(model);
                    return Created($"api/product/{model.Id}", model);
                }
                return BadRequest($"unable to save");
               
            }

            return BadRequest("It failed");
              

        }
        
    }
}
