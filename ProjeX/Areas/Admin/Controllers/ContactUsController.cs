using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactUsController : Controller
    {
        private readonly IContactUsServices contactUsServices;

        public ContactUsController(IContactUsServices contactUsServices)
        {
            this.contactUsServices = contactUsServices;
        }

        public IActionResult Index()
        {
            var values = contactUsServices.TGetListContactUsByTrue();
            return View(values);
        }
        
    }
}
