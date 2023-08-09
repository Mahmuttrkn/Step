using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using ProjeX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.Controllers
{
    public class ForgetPasswordController : Controller
    {
        private readonly UserManager<AppUser> userManager;

        public ForgetPasswordController(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordViewModel model)
        {
            var user = await userManager.FindByEmailAsync(model.Mail);
            string passwordtoken = await userManager.GeneratePasswordResetTokenAsync(user);
            var tokenlink = Url.Action("ResetPassword", "ForgetPassword", new
            {
                userıd = user.Id,
                token=passwordtoken
            },HttpContext.Request.Scheme);

            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "mahmut.trkn@hotmail.com");

            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.Mail);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = tokenlink;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = "Şifre Sıfırlama";

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.hotmail.com", 587, false);
            client.Authenticate("mahmut.trkn@hotmail.com", "aqbyfdpekxchjnyo");
            client.Send(mimeMessage);
            client.Disconnect(true);



            return View();
        }

    }
}
