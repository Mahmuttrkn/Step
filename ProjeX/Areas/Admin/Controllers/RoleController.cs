using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjeX.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.Areas.Admin.Controllers
{
    [Area("Admin")]
   
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> roleManager;
        private readonly UserManager<AppUser> userManager;

        public RoleController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = roleManager.Roles.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleViewModel model)
        {
            AppRole role = new AppRole()
            {
                Name = model.RoleName
            };
            var result = await roleManager.CreateAsync(role);
            if(result.Succeeded)
            {
                return Redirect("https://localhost:44302/Admin/Role/Index");
            }
            else
            {
                return View();
            }

        }
        public async Task<IActionResult> DeleteRol(int id)
        {
            var value = roleManager.Roles.FirstOrDefault(x => x.Id == id);
            await roleManager.DeleteAsync(value);
            return Redirect("https://localhost:44302/Admin/Role/Index");
        }
        [HttpGet]
        public async Task< IActionResult> UpdateRole(int id)
        {
            var value = roleManager.Roles.FirstOrDefault(x => x.Id == id);
            RoleUpdateViewModel roleUpdate = new RoleUpdateViewModel
            {
                RoleID = value.Id,
                RoleName = value.Name
            };
            return View(roleUpdate);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateRole(RoleUpdateViewModel model)
        {
            var value = roleManager.Roles.FirstOrDefault(x => x.Id == model.RoleID);
            value.Name = model.RoleName;
            await roleManager.UpdateAsync(value);
            return Redirect("https://localhost:44302/Admin/Role/Index");
        }
        public IActionResult UserList()
        {
            var values = userManager.Users.ToList();
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> AssigneRole(int id)
        {
            var user = userManager.Users.FirstOrDefault(x => x.Id == id);
            TempData["UserId"] = user.Id;
            var roles = roleManager.Roles.ToList();
            var userroles = await userManager.GetRolesAsync(user);
            List<AssigneRoleViewModel> assigneRoleViewModels = new List<AssigneRoleViewModel>();
            foreach (var item in roles)
            {
                AssigneRoleViewModel model = new AssigneRoleViewModel();
                model.RoleID = item.Id;
                model.RoleName = item.Name;
                model.RoleExist = userroles.Contains(item.Name);
                assigneRoleViewModels.Add(model);
            }
            return View(assigneRoleViewModels);
        }
        [HttpPost]
        public async Task<IActionResult> AssigneRole(List<AssigneRoleViewModel> model)
        {
            var userid = (int)TempData["UserId"];
            var user = userManager.Users.FirstOrDefault(x => x.Id == userid);
            foreach (var item in model)
            {
                if(item.RoleExist)
                {
                    await userManager.AddToRoleAsync(user, item.RoleName);
                }
                else
                {
                    await userManager.RemoveFromRoleAsync(user, item.RoleName);
                }
            }
            return Redirect("https://localhost:44302/Admin/Role/Index");
        }
    }
}
