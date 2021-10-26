using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PackagesManagement.Models.Login;
using System.Threading.Tasks;

namespace PackagesManagement.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser<int>> _userManager;
        private readonly SignInManager<IdentityUser<int>> _signInManager;
        public AccountController(UserManager<IdentityUser<int>> userManager, SignInManager<IdentityUser<int>> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Login(string returnUrl = null)
        {
            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            return RedirectToAction(nameof(HomeController.Index), "Home");
            if (User.Identity.IsAuthenticated)
            {
                await _signInManager.SignOutAsync();
            }
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe,
                    lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl))
                        return LocalRedirect(returnUrl);
                    else
                        return RedirectToAction(nameof(HomeController.Index), "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "wrong username or password");
                    return View(model);
                }
            }
            else
                return View(model);
        }
    }
}
