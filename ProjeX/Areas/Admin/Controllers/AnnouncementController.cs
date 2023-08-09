using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.DTOS.Announcement;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjeX.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementServices announcementServices;
        private readonly IMapper mapper;

        public AnnouncementController(IAnnouncementServices announcementServices, IMapper mapper)
        {
            this.announcementServices = announcementServices;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            var values = mapper.Map<List<AnnouncementListDTO>>(announcementServices.GetList());
          
            return View(values);
        }
        [HttpGet]
        public IActionResult AnnouncementAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AnnouncementAdd(AnnouncementAddDTO p)
        {
             if(ModelState.IsValid)
            {
                announcementServices.Tadd(new Announcement()
                {
                    Content = p.Content,
                    Title = p.Title,
                    Date=Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return Redirect("https://localhost:44302/Admin/Announcement/Index");
            }
            return View(p);
        }
        public IActionResult AnnouncementDelete(int id)
        {
            var values = announcementServices.TGetByID(id);
            announcementServices.TDelete(values);
            return Redirect("https://localhost:44302/Admin/Announcement/Index");
        }
        [HttpGet]
        public IActionResult AnnouncementUpdate(int id)
        {
            var values = mapper.Map<AnnouncementUpdateDTO>(announcementServices.TGetByID(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult AnnouncementUpdate(AnnouncementUpdateDTO model)
        {
            if (ModelState.IsValid)
            {
                announcementServices.TUpdate(new Announcement()
                    {
                    AnnouncementID=model.AnnouncementID,
                    Content=model.Content,
                    Title=model.Title,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())

                });
                return Redirect("https://localhost:44302/Admin/Announcement/Index");
            }
            return View(model);
        }
    }
}
