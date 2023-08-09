using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.ViewComponents.Default
{
    public class Feature : ViewComponent
    {
        FeatureManager fm = new FeatureManager(new EFFeatureDal());
        public IViewComponentResult Invoke()
        {
            var values =fm.GetList();
            return View(values);
        }
    }
}

