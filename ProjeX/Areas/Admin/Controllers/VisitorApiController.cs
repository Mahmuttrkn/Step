using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjeX.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProjeX.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class VisitorApiController : Controller
    {
        private readonly IHttpClientFactory httpClientFactory;

        public VisitorApiController(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client = httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:39096/api/Visitor");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<VisitorViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult VisitorCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> VisitorCreate(VisitorViewModel p)
        {
            var client = httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(p);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:39096/api/Visitor", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return Redirect("https://localhost:44302/Admin/VisitorApi/Index");
            }
            return View();
        }
        public async Task<IActionResult> VisitorDelete(int id)
        {
            var client = httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:39096/api/Visitor/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return Redirect("https://localhost:44302/Admin/VisitorApi/Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> VisitorUpdate(int id)
        {
            var client = httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:39096/api/Visitor/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<VisitorViewModel>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> VisitorUpdate(VisitorViewModel p)
        {
            var client = httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(p);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:39096/api/Visitor", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return Redirect("https://localhost:44302/Admin/VisitorApi/Index");
            }
            return View();
        }
    }
}
