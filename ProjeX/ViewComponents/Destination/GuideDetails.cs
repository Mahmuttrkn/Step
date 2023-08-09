using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.ViewComponents.Destination
{
    public class GuideDetails: ViewComponent
    {
        private readonly IGuideServices guideServices;

        public GuideDetails(IGuideServices guideServices)
        {
            this.guideServices = guideServices;
        }
        public IViewComponentResult Invoke()
        {
            var values = guideServices.TGetByID(1);
            return View(values);
        }
    }
}
