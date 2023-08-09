using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.Controllers
{
   
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EFCommentDal());
        private readonly UserManager<AppUser> userManager;

        public CommentController(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }

        [HttpGet]
        public PartialViewResult AddComment()
        {
            //ViewBag.destID = id;
            //var values =  userManager.FindByNameAsync(User.Identity.Name);
            //ViewBag.userID = values.Id;
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddComment(Comment p)
        {

            p.CommentDate = Convert.ToDateTime(DateTime.Today.ToShortDateString());
            p.CommentState = true;
            cm.Tadd(p);
            return RedirectToAction("Index", "Destination");
        }
    }
}
