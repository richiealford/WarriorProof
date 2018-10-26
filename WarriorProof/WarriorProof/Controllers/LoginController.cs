using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using WarriorProof.Contracts.Interfaces.Services;
using WarriorProof.Models;

namespace WarriorProof.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserService _userService;

        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult TryLogin(LoginViewModel model)
        {
            var loginSuccess = _userService.IsAuthorized(model.UserName, model.Password);
            if (loginSuccess)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, model.UserName),
                    new Claim(ClaimTypes.Role, "User"),
                };

                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties { };


                Task t = HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);
                t.Wait();

                return RedirectToAction("Index", "WarriorLand");
            }
            else
            {
                ViewBag.AuthMessage = "Login Failed";
                return View("Index");
            }
        }

        private Task SignInAsync(object user, bool isPersistent)
        {
            throw new NotImplementedException();
        }
    }
}
