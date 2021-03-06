﻿using BlogProjectFront.ApiServices.Interfaces;
using BlogProjectFront.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BlogProjectFront.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAuthApiService _authApiService;
        public AccountController(IAuthApiService authApiService)
        {
            _authApiService = authApiService;
        }
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> SignIn(AppUserLoginModel model)
        {
            if (await _authApiService.SignIn(model))
            {
                return RedirectToAction("Index", "Blog", new { @area = "Admin" });
            }

            return View();
        }

    }
}
