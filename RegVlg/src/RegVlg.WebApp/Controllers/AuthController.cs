using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using RegVlg.Services.Auth;

namespace RegVlg.WebApp.Controllers
{
    [Route("[controller]/[action]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(
            IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Produces("text/html")]
        public async Task<string> Login()
        {
            var html = ""; // await System.IO.File.ReadAllTextAsync(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Content", "Auth", "Login.html"));
            return html;
        }

        [HttpPost]
        public void Login(string login, string password, string returnUrl = null)
        {
            var principal = _userService.GetClaimsPrincipal(login);
            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
            
            if (!string.IsNullOrEmpty(returnUrl))
            {
                Redirect(returnUrl);
            }
            else
            {
                RedirectToAction("Index", "Home");
            }
        }

        public async Task Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            RedirectToAction(nameof(Login));
        }
    }
}
