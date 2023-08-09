using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationController : Controller
    {
        private readonly IDestinationServices destinationServices;

        public DestinationController(IDestinationServices destinationServices)
        {
            this.destinationServices = destinationServices;
        }

        public IActionResult Index()
        {
            var values = destinationServices.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddIndex()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddIndex(Destination p)
        {
            destinationServices.Tadd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteIndex(int id)
        {
            var values = destinationServices.TGetByID(id);
            destinationServices.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateIndex(int id)
        {
            var values = destinationServices.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateIndex(Destination p)
        {
            destinationServices.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
