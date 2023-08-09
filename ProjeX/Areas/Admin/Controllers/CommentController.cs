using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        private readonly ICommentServices commentServices;

        public CommentController(ICommentServices commentServices)
        {
            this.commentServices = commentServices;
        }

        public IActionResult Index()
        {
            var values = commentServices.TGetListCommentWithDestination();
            return View(values);
        }
        public IActionResult DeleteComment(int id)
        {
            var values = commentServices.TGetByID(id);
            commentServices.TDelete(values);
            return RedirectToAction("Index","Admin");
        }
    }
}
