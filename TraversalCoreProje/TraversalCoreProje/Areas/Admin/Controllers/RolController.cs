using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RolController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public RolController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult RolEkle()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RolEkle(CreateRolViewModel p)
        {
            AppRole role = new AppRole()
            {
                Name = p.RoleName
            };
            var result = await _roleManager.CreateAsync(role);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        public async Task<IActionResult> RolSil(int id)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            await _roleManager.DeleteAsync(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult RolGuncelle(int id)
        {
            var value = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            UpdateRoleViewModel updateRoleViewModel = new UpdateRoleViewModel
            {
                RoleID = value.Id,
                RoleName = value.Name
            };
            return View(updateRoleViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> RolGuncelle(UpdateRoleViewModel p)
        {
            var value = _roleManager.Roles.FirstOrDefault(x => x.Id == p.RoleID);
            value.Name = p.RoleName;
            await _roleManager.UpdateAsync(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> RolAta(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            TempData["UserID"] = user.Id;
            var roles = _roleManager.Roles.ToList();
            var userRoles = await _userManager.GetRolesAsync(user);
            List<RoleAtamaViewModel> roleAtamaViewModels = new List<RoleAtamaViewModel>();
            foreach (var x in roles)
            {
                RoleAtamaViewModel model = new RoleAtamaViewModel();
                model.RoleId = x.Id;
                model.RoleName = x.Name;
                model.RoleExist = userRoles.Contains(x.Name);
                roleAtamaViewModels.Add(model);
            }
            return View(roleAtamaViewModels);
        }
        [HttpPost]
        public async Task<IActionResult> RolAta(List<RoleAtamaViewModel> model)
        {
            var userid = (int)TempData["UserID"];
            var user = _userManager.Users.FirstOrDefault(x=>x.Id==userid);
            foreach (var x in model)
            {
                if (x.RoleExist)
                {
                    await _userManager.AddToRoleAsync(user, x.RoleName);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, x.RoleName);
                }
            }
            return RedirectToAction("Index","Kullanicilar");
        }
    }
}
