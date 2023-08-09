using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjeX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(cities);
            return Json(jsonCity);
        }

        public static List<City> cities = new List<City>()
        {
            new City
            {
                CityId=1,
                CityName="Üsküp",
                CityCountry="Makedonya"
            },
            new City
            {
                CityId=2,
                CityName="Ankara",
                CityCountry="Türkiye"
            }
        };
    }
}
