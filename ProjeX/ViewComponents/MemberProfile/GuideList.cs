using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.ViewComponents.MemberProfile
{
    public class GuideList : ViewComponent
    {
        GuideManager gm = new GuideManager(new EFGuideDal());
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = gm.GetList();
            return View(values);
        }
    }
}
