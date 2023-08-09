using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRApı.Dal;
using SignalRApı.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRApı.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorController : ControllerBase
    {
        private readonly VisitorService visitorService;

        public VisitorController(VisitorService visitorService)
        {
            this.visitorService = visitorService;
        }
        [HttpGet]
        public IActionResult CreateVisitor()
        {
            Random random = new Random();
            Enumerable.Range(1, 10).ToList().ForEach(x =>
             {
                 foreach (ECity item in Enum.GetValues(typeof(ECity)))
                 {
                     var newVisitor = new Visitor
                     {
                         City = item,
                         CityVisitCount = random.Next(100, 2000),
                         VisitDate = DateTime.Now.AddDays(x)
                     };
                     visitorService.SaveVisitor(newVisitor).Wait();
                     System.Threading.Thread.Sleep(1000);
                 }
             });
            return Ok("Ziyaretçiler Başarılı Olarak Eklendi");
        }
    }
}
