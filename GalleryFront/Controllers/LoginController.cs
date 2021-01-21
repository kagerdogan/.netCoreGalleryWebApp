using Gallery.Models;
using Gallery.ViewModels;
using GalleryBusiness.Interface;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace GalleryFront.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserLogin _userlogin;
        public LoginController(IUserLogin userLogin)
        {
            _userlogin = userLogin;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel Ulogin)
        {
            if (_userlogin.CheckPass(Ulogin) == true && _userlogin.isAdmin(Ulogin.Username))
            {
                var ownRole = new List<Claim>();
                ownRole.Add(new Claim(ClaimTypes.Role, "admin"));//databaseden gelen nesnenın
                ownRole.Add(new Claim(ClaimTypes.Name, Ulogin.Username));
                var ownIdentity = new ClaimsIdentity(ownRole, CookieAuthenticationDefaults.AuthenticationScheme);
                var ownPrincipal = new ClaimsPrincipal(ownIdentity);
                var ownSchema = CookieAuthenticationDefaults.AuthenticationScheme;
                await HttpContext.SignInAsync(ownSchema, ownPrincipal);
                HttpContext.Session.SetString("currentUser", Ulogin.Username);
                return RedirectToAction("Index", "Home");
            }
            else
                return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(UserLoginModel userLoginModel)
        {
            _userlogin.Register(userLoginModel);
            return RedirectToAction("Login");
        }
    }
}
