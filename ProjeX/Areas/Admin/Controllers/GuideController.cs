using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GuideController : Controller
    {
        private readonly IGuideServices guideServices;
        private readonly UserManager<Guide> _userManager;

        GuideValidator gv = new GuideValidator();

        public GuideController(IGuideServices guideServices)
        {
            this.guideServices = guideServices;
         
        }

        public IActionResult Index()
        {
            var values = guideServices.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddGuide()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddGuide(Guide p)
        {
            //GuideValidator gv = new GuideValidator();
            ValidationResult result = gv.Validate(p);
            if (result.IsValid)
            {
                guideServices.Tadd(p);
                return Redirect("https://localhost:44302/Admin/Guide/Index");

            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }
        [HttpGet]
        public IActionResult EditGuide(int id)
        {

            var values = guideServices.TGetByID(id);
            return View(values);
        }
        

     //Guide için yeni bir buton tanımlanacak adı da ımage değiştir olacak sonra burada tanımlanan resim metodu orayada tanımlanacak böylece güncelleme işlemi yapacaz.
        

        [HttpPost]
        public IActionResult EditGuide(Guide p)
        {
            guideServices.TUpdate(p);
            return Redirect("https://localhost:44302/Admin/Guide/Index");
        }

        public IActionResult ChangeToStatus(int id)
        {

           var values= guideServices.TGetByID(id);
            if (values.Status == true)
            {
                values.Status = false;
                guideServices.TUpdate(values);
            }
            else
            {
                values.Status = true;
                guideServices.TUpdate(values);
            }
            return Redirect("https://localhost:44302/Admin/Guide/Index");
        }

    }
        //public IActionResult ChangeToFalse(int id)
        //{

        //    return RedirectToAction("Index");

        //}

    }

//guide edit ve true false işlemlerini yapalım bitsin