using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.DTOS.ContactDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactUsServices contactUsServices;
        private readonly IMapper mapper;

        public ContactController(IContactUsServices contactUsServices, IMapper mapper)
        {
            this.contactUsServices = contactUsServices;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Index(SendMessageDTO model)
        {
            if(ModelState.IsValid)
            {
                contactUsServices.Tadd(new ContactUs()
                {
                    Mail = model.Mail,
                    MessageBody = model.MessageBody,
                    MessageStatus = true,
                    Name = model.Name,
                    Subject = model.Subject,
                    MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return Redirect("https://localhost:44302/Default/Index");
            }

            return View(model);
        }
    }
}
