﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Service.Services;
using Service.Services.Interfaces;
using Service.ViewModels;

namespace GameLib.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IStaticDataService _staticDataService;
        private readonly IEmailService _emailService;
        private readonly ICartService _cartService;
        private readonly AppDbContext _context;

        public AccountController(UserManager<AppUser> userManager,
                                 SignInManager<AppUser> signInManager,
                                 IStaticDataService staticDataService,
                                 IEmailService emailService,
                                 ICartService cartService,
                                 AppDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _staticDataService = staticDataService;
            _emailService = emailService;
            _cartService = cartService;
            _context = context;
        }



        [HttpGet]
        public IActionResult Register()
        {
            Dictionary<string, string> sectionHeaders = _staticDataService.GetAllSectionHeaders();

            RegisterVM model = new RegisterVM
            {
                SectionHeaders = sectionHeaders
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (!ModelState.IsValid)
            {
                model.SectionHeaders = _staticDataService.GetAllSectionHeaders();
                return View(model);
            }

            AppUser newUser = new AppUser
            {
                FullName = model.FullName,
                UserName = model.Username,
                Email = model.Email
            };

            var result = await _userManager.CreateAsync(newUser, model.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

                model.SectionHeaders = _staticDataService.GetAllSectionHeaders();
                return View(model);
            }

            TempData["Email"] = newUser.Email;

            string token = await _userManager.GenerateEmailConfirmationTokenAsync(newUser);
            string link = Url.Action("ConfirmEmail", "Account", new { userId = newUser.Id, token }, Request.Scheme, Request.Host.ToString());
            string subject = "Email Confirmation";
            string html;

            using (StreamReader reader = new StreamReader("wwwroot/assets/templates/VerifyEmail.html"))
            {
                html = reader.ReadToEnd();
            }

            string fullName = newUser.FullName;

            html = html.Replace("{{fullName}}", fullName);
            html = html.Replace("{{link}}", link);

            _emailService.Send(newUser.Email, subject, html);

            return RedirectToAction(nameof(VerifyEmail));
        }

        [HttpGet]
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            try
            {
                if (userId is null || token is null) throw new ArgumentNullException();

                AppUser user = await _userManager.FindByIdAsync(userId);

                if (user is null) throw new NullReferenceException();

                await _userManager.ConfirmEmailAsync(user, token);
                await _signInManager.SignInAsync(user, false);
                await _cartService.CreateUserCartAsync(userId);

                return RedirectToAction("Index", "Home");
            }

            catch (ArgumentNullException)
            {
                return BadRequest();
            }

            catch(NullReferenceException)
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult VerifyEmail()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            Dictionary<string, string> sectionHeaders = _staticDataService.GetAllSectionHeaders();

            LoginVM model = new LoginVM
            {
                SectionHeaders = sectionHeaders
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM model)
        {
            if (!ModelState.IsValid)
            {
                model.SectionHeaders = _staticDataService.GetAllSectionHeaders();
                return View(model);
            }

            AppUser user = await _userManager.FindByEmailAsync(model.UsernameOrEmail);

            if (user is null)
            {
                user = await _userManager.FindByNameAsync(model.UsernameOrEmail);
            }

            if (user is null)
            {
                ModelState.AddModelError(string.Empty, "Email or password is wrong.");
                model.SectionHeaders = _staticDataService.GetAllSectionHeaders();
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, true);

            if (!result.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "Email or password is wrong.");
                model.SectionHeaders = _staticDataService.GetAllSectionHeaders();
                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return Ok();
        }
    }
}