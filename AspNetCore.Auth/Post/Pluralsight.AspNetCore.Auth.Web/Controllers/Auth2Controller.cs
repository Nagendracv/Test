using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Pluralsight.AspNetCore.Auth.Web.Services;
using Pluralsight.AspNetCore.Auth.Web.Models;
using System.Security.Claims;

namespace Pluralsight.AspNetCore.Auth.Web.Controllers
{
    [Route("auth2")]
    public class Auth2Controller : Controller
    {
        private IUserService _userService;

        public Auth2Controller(IUserService userService)
        {
            _userService = userService;
        }

        [Route("signin2")]
        public IActionResult SignIn2()
        {
            return View();
        }

        [Route("signin2local")]
        [HttpPost]
        public async Task<IActionResult> SignIn2Local(SignInModel model, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                User user;
                if (await _userService.ValidateCredentials(model.Username, model.Password, out user))
                {
                    await SignInUser(user.Username);
                    if (returnUrl != null)
                    {
                        return Redirect(returnUrl);
                    }
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(model);
        }

        public async Task SignInUser(string username)
        {
            var claims = new List<Claim> {
                new Claim(ClaimTypes.NameIdentifier, username),
                new Claim("name", username)
            };
            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme, "name", null);
            var principal = new ClaimsPrincipal(identity);
            await HttpContext.SignInAsync(principal);
        }

        [Route("signout2")]
        [HttpPost]
        public async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}