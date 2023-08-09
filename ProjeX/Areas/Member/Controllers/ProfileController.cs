using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjeX.Areas.Member.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ProfileModel profileModel = new ProfileModel();
            profileModel.name = values.Name;
            profileModel.surname = values.Surname;
            profileModel.mail = values.Email;
            profileModel.imageurl = values.ImageUrl;
            profileModel.phonenumber = values.PhoneNumber;
            return View(profileModel);
        }

        [HttpPost]
        
        public async Task<IActionResult> Index(ProfileModel p) //Burada profil resmi güncelleme seçme işlemi gerçekleştirildi.
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (p.image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.image.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/userimages/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                user.ImageUrl = imagename;
            }
            user.Name = p.name;
            user.Surname = p.surname;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.password);
            user.PhoneNumber = p.phonenumber;
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("SignIn", "Login");
            }
            return View(); //Guide için yeni bir buton tanımlanacak adı da ımage değiştir olacak sonra burada tanımlanan resim metodu orayada tanımlanacak böylece güncelleme işlemi yapacaz.
        }
    }
}
