using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager dm = new DestinationManager(new EFDestinationDal());
        private readonly UserManager<AppUser> userManager;
       //private readonly GuideManager<Guide> guideManager;

        public DestinationController(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }
        public IActionResult Index()
        {
            var values = dm.TGetList();
            return View(values);
           
        }
        [HttpGet]
        public async Task<IActionResult> DestinationDetails(int id)
        {
            ViewBag.i = id;
            ViewBag.destID = id;
            var values = dm.TGetDestinationWithGuide(id);
            var value = await userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userID = value.Id;
            return View(values);
        }
        [HttpPost]
        public IActionResult DestinationDetails(Destination p)
        {
            return View();
        }
    }
}
