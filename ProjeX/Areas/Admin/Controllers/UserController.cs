using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IUserServices userService;
        private readonly IReservationServices reservationServices;

        public UserController(IUserServices userService, IReservationServices reservationServices)
        {
            this.userService = userService;
            this.reservationServices = reservationServices;
        }

        public IActionResult Index()
        {
            var values = userService.GetList();
            return View(values);
        }
        public IActionResult DeleteUser(int id)
        {
            var values = userService.TGetByID(id);
            userService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateIndex(int id)
        {
            var values = userService.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateIndex(AppUser p)
        {
            userService.TUpdate(p);
            return RedirectToAction("Index");
        }
        public IActionResult ComentUser(int id)
        {
            userService.GetList();
            return View();
        }
        public IActionResult ReservationUser(int id)
        {
            var values=reservationServices.GetListWithReservationByAccepted(id);
            return View(values);
        }
    }
}
