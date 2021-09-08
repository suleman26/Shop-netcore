using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dutch_retreat.Data;
using dutch_retreat.ModelViews;
using dutch_retreat.Services;
using Gremlin.Net.Process.Traversal;
using Microsoft.AspNetCore.Mvc;

namespace dutch_retreat.Controllers
{
    public class AppController:Controller
    {
        private readonly IDutchRepository _repository;

        public IMailService _mailService { get; private set; }

        public AppController(IMailService mailService, IDutchRepository repository)
        {
            _mailService = mailService;
            _repository = repository;
           
        }
        public IActionResult Index()
        {

            return View();
        }
        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
  
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactModelView model)
        {
            if (ModelState.IsValid) 
            {
                //send email

                _mailService.SendMessage("suleman sani", model.Subject, $"From: {model.Name}-{model.Email} message: {model.Message}");
                ViewBag.UserMessage = "Mail sent !";
                ModelState.Clear();
            }

            return View();
           
        }

        public IActionResult About()
        {
            ViewBag.Tittle = "About us";

            return View();
        }

        public IActionResult Shop()
        {
            ViewBag.Tittle = "NAIJA SHOP";
            var result = _repository.GetAllProducts();
            return View(result);
        }   

  
    }
}
