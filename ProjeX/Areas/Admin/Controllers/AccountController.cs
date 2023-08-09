using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjeX.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly IAccountServices accountServices;

        public AccountController(IAccountServices accountServices)
        {
            this.accountServices = accountServices;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AccountWievModel accountWievModel)
        {
            var valueSender = accountServices.TGetById(accountWievModel.SenderID);
            var valueReceiver = accountServices.TGetById(accountWievModel.ReceiverID);

            valueSender.Amount -= accountWievModel.Amount;
            valueReceiver.Amount += accountWievModel.Amount;

            List<Account> modifedAccount = new List<Account>()
            {
                valueSender,
                valueReceiver
            };
            accountServices.TMultiUpdate(modifedAccount);
            return Redirect("https://localhost:44302/Admin/Dashboard/Index");
        }
    }
}
