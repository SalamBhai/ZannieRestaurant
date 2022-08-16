using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Claims;
using System.Threading.Tasks;
using Cakes_N_Treats_By_Zannie.Interfaces.IServices;
using Cakes_N_Treats_By_Zannie.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cakes_N_Treats_By_Zannie.Controllers
{
    public class UserController :Controller
    {
        private readonly IUserService _userservice;
        private readonly IWebHostEnvironment _webhostEnvironment;
        public UserController(IUserService userservice, IWebHostEnvironment whe)
        {
            _userservice=userservice;
            _webhostEnvironment=whe;
        }

        public IActionResult Index()
        {
            return View("Create");
        }
        //[Authorize(Roles="Customer")]
        public IActionResult CreateCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCustomer(CreateUserRequestModel model, IFormFile Userphoto)
        {
            string userphotopath= Path.Combine(_webhostEnvironment.WebRootPath, "UserPhoto");
            Directory.CreateDirectory(userphotopath);
            var contenttype= Userphoto.ContentType.Split('/')[1];
            var userimage= $"User{Guid.NewGuid().ToString().Substring(2,6)}.{contenttype}";
            var fulluserphotopath= Path.Combine(userphotopath, userimage);
            using(var photostore= new FileStream(fulluserphotopath, FileMode.Create))
            {
                Userphoto.CopyTo(photostore);
            }
            model.UserPhoto=userimage;
            _userservice.CreateCustomer(model);
            return RedirectToAction("Login","User");
        }
        [Authorize(Roles="Administrator")]
        public IActionResult CreateAdministrator()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateAdministrator(CreateUserRequestModel model, IFormFile Userphoto)
        {
            string userphotopath= Path.Combine(_webhostEnvironment.WebRootPath, "UserPhoto");
            Directory.CreateDirectory(userphotopath);
            var contenttype= Userphoto.ContentType.Split('/')[1];
            var userimage= $"User{Guid.NewGuid().ToString().Substring(2,6)}.{contenttype}";
            var fulluserphotopath= Path.Combine(userphotopath, userimage);
            using(var photostore= new FileStream(fulluserphotopath, FileMode.Create))
            {
                Userphoto.CopyTo(photostore);
            }
            model.UserPhoto=userimage;
            _userservice.CreateAdministrator(model);
            return RedirectToAction("Login","User");
        }
        [Authorize(Roles="Dispatcher")]
         public IActionResult CreateDispatcher()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateDispatcher(CreateUserRequestModel model, IFormFile Userphoto)
        {
            string userphotopath= Path.Combine(_webhostEnvironment.WebRootPath, "UserPhoto");
            Directory.CreateDirectory(userphotopath);
            var contenttype= Userphoto.ContentType.Split('/')[1];
            var userimage= $"User{Guid.NewGuid().ToString().Substring(2,6)}.{contenttype}";
            var fulluserphotopath= Path.Combine(userphotopath, userimage);
            using(var photostore= new FileStream(fulluserphotopath, FileMode.Create))
            {
                Userphoto.CopyTo(photostore);
            }
            model.UserPhoto=userimage;
            _userservice.CreateAdministrator(model);
            return RedirectToAction("Login","User");
        }
        
        public IActionResult Update()
        {
            var id= int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var updateuser= _userservice.GetCustomerById(id);
           if(updateuser== null)
           {
               return NotFound();
           }
            return View();
        }
        
        [HttpPost]
        public IActionResult Update( UpdateUserRequestModel user)
        {
            var id= int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
           _userservice.Update(id,user);
           if(user.UserType==Entities.Enums.UserType.Administrator)
            {
             return RedirectToAction("AdminDashboard","User");
            }
            else if (user.UserType==Entities.Enums.UserType.Dispatcher)
            {
             return RedirectToAction("DispatcherDashboard","User");
            }
            return RedirectToAction("UserDashBoard","User");
        }
        
        public IActionResult GetUser()
        {
            var id= int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
           var user= _userservice.GetCustomerById(id);
           return View(user);
        }
        [Authorize(Roles="Administrator")]
        public IActionResult GetUsers()
        {
            var users= _userservice.GetCustomers();
            return View(users);
        }
        [Authorize(Roles="Customer")]
        [HttpPost]
        public IActionResult Delete()
        {
            var id= int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var deleteuser= _userservice.GetCustomerById(id);
            return View();
        }
          public IActionResult DeletionSuccess()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
         public async Task<IActionResult> Login(UserLoginRequestModel model)
        {
            var user=_userservice.Login(model);
            if (user != null)
            {
                var claims = new List<Claim>
                {
                     new Claim(ClaimTypes.NameIdentifier , user.Id.ToString()),
                     new Claim(ClaimTypes.Role, user.UserType.ToString()),
                     new Claim(ClaimTypes.Email, user.EmailAddress),
                     new Claim(ClaimTypes.Name, user.FullName),
                     
                };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                var properties = new AuthenticationProperties();
                
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, properties);
                if(user.UserType==Entities.Enums.UserType.Administrator)
                {
                    return RedirectToAction("AdminDashboard","User");
                }
                else if (user.UserType==Entities.Enums.UserType.Dispatcher)
                {
                     return RedirectToAction("DispatcherDashboard","User");
                }
            }
            else
            {
                return NotFound("Invalid Login Credentials");
            }
            return RedirectToAction("UserDashBoard","User");
         }
         [Authorize(Roles="Customer")]
         public IActionResult UserDashBoard()
         {
           return View();
         }
         [Authorize(Roles="Administrator")]
         public IActionResult AdminDashboard()
         {
             return View();
         }
          [Authorize(Roles="Dispatcher")]
         public IActionResult DispatcherDashboard()
         {
             return View();
         }
         public async Task<IActionResult> Logout()
         {
             await HttpContext.SignOutAsync();
             return RedirectToAction("Index" ,"Home");
         }
    }
}