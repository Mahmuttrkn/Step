using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using ProjeX.Models;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MailController : Controller
    {
        //private readonly MailSettings _mailSettings;

        //public MailController(MailSettings mailSettings)
        //{
        //    _mailSettings = mailSettings;
        //}

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(MailRequest p)
        {
            var email = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin","mahmut.trkn@hotmail.com");
            email.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User",p.ReceiverMail);
            email.To.Add(mailboxAddressTo);

            email.Subject = p.Subject;

            var builder = new BodyBuilder();

            email.Body = builder.ToMessageBody();

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.hotmail.com", 587, false);
            client.Authenticate("mahmut.trkn@hotmail.com", "aqbyfdpekxchjnyo");
            client.Send(email);
            client.Disconnect(true);

            return View();
        }

        

    }
}
