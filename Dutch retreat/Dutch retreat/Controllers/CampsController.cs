using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace dutch_retreat.Controllers
{
    public class CampsController : Controller
    {
        public CampsController()
        {

        }

        public string url = "http://localhost:9999/api/Camps";
        publicvar campList;

        public async Task<IActionResult> Camp()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(url))
                {
                    var data = await response.Content.ReadAsStringAsync();
                    campList = JsonConvert.DeserializeObject<IEnumerable<Camp>>(data);
                }
                    
            }

            return View(campList);
        }
        
    }
}
