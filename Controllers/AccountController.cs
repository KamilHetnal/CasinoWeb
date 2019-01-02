using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasinoWeb.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CasinoWeb.Contollers
{
	public class AccountController : Controller
	{
		protected UserManager<IdentityUser> UserManager { get; }
		protected SignInManager<IdentityUser> SignInManager { get; }

		public AccountController(UserManager<IdentityUser> userManager,
		SignInManager<IdentityUser> signInManager)
		{
			UserManager = userManager;
			SignInManager = signInManager;
		}
		// GET: /<controller>/
		[HttpGet]
		public IActionResult Register()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Register(RegisterViewModel viewModel)
		{
			if (ModelState.IsValid)
			{
				var user = new IdentityUser(viewModel.Login) { Email = viewModel.Email };
				var result = await UserManager.CreateAsync(user, viewModel.Password);

				if (result.Succeeded)
				{
					var autoLogin = await SignInManager.PasswordSignInAsync(viewModel.Login,
										viewModel.Password, true, false);
					if (result.Succeeded)
					{
						return RedirectToAction("Index", "Home");
					}
					else
					{
						ModelState.AddModelError("", "Nie można się zalogować!");
					}
					return RedirectToAction("Index", "Home");
				}
				foreach (var error in result.Errors)
				{
					ModelState.AddModelError("", error.Description);
				}
			}
			return View(viewModel);
		}
		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Login(LoginViewModel viewModel)
		{
			if (ModelState.IsValid)
			{
				var result = await SignInManager.PasswordSignInAsync(viewModel.Login,
										viewModel.Password, viewModel.RememberMe, false);
				if (result.Succeeded)
				{
					return RedirectToAction("Index", "Home");
				}
				else
				{
					ModelState.AddModelError("", "Nie można się zalogować!");
				}
			}
			return View(viewModel);
		}
		[HttpGet]
		public async Task<IActionResult> LogOut()
		{
			await SignInManager.SignOutAsync();
			return RedirectToAction("Index", "Home");
		}
	}
}
