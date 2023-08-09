using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.Controllers
{
    public class PartialViewController : Controller
    {
        public IActionResult Index()
        {
            return PartialView();
        }
    }
}
