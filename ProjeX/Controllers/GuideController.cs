using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.Controllers
{
    public class GuideController : Controller
    {
        //GuideManager gm = new GuideManager(new EFGuideDal());
        private readonly IGuideServices guideServices;

        public GuideController(IGuideServices guideServices)
        {
            this.guideServices = guideServices;
        }

        public async Task<IActionResult> Index()
        {
            //var values = gm.GetList();
            var values = guideServices.GetList();
            return View(values);
        }
    }
}
