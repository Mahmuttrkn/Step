using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.ViewComponents.Comment
{
    public class Comment:ViewComponent
    {
        CommentManager cm = new CommentManager(new EFCommentDal());
        Context context = new Context();
        public IViewComponentResult Invoke(int id)
        {

            ViewBag.count = context.Comments.Where(x => x.DestinationID == id).Count();
            var values = cm.TGetListCommentWithDestinationAndUser(id);
            return View(values);
        }
    }
}
