﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.ViewComponents.AdminDashboard
{
    public class DestinationStatistic : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
