using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeedStore.MediatR.Command;
using WeedStore.Models.DTOs;
using MediatR;
using WeedStore.Models.User;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using WeedStore.MediatR.Query;

namespace WeedStore.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMediator _mediator;
        private UserManager<UserModel> _userManager;
        private SignInManager<UserModel> _signInManager;

        public AccountController(IMediator mediatR, UserManager<UserModel> userManager, SignInManager<UserModel> signInManager)
        {
            _mediator = mediatR;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View("Register");
        }
        [HttpPost]
        public async Task<ActionResult<UserModel>> Register([FromForm] UserRegisterDTOs userRegisterDTOs)
        {
            //var command = new UserRegisterCommand(userRegisterDTOs);
            //var result = _mediatR.Send(command);
            //if (result.Result != null)
            //{
            //    return result.Result;
            //}
            //return NotFound();
            var newUser = new UserModel
            {
                First_name = userRegisterDTOs.First_name,
                Second_name = userRegisterDTOs.Second_name,
                Email = userRegisterDTOs.Email,
                Address = userRegisterDTOs.Address,
                Cart = "[]",
                UserName = userRegisterDTOs.UserName
            };
            var result = await _userManager.CreateAsync(newUser, userRegisterDTOs.Password);

            if (result.Succeeded)
            {

                //var user = await _userManager.FindByEmailAsync(userRegisterDTOs.Email);
                //await _userManager.AddToRoleAsync(user, "admin");

                return newUser;
            }
            return NotFound();

        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>Login([FromForm] UserLoginDTOs userLoginDTOs)
        {
            var user = await _userManager.FindByEmailAsync(userLoginDTOs.Email);
            var result = await _signInManager.PasswordSignInAsync(user.UserName, userLoginDTOs.Password, false, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
             return NotFound("Ivalid Data"); ;
            //var command = new UserLoginCommand(userLoginDTOs);
            //var result = _mediatR.Send(command);
            //if (result.Result != null)
            //{
            //   return RedirectToAction("Index", "Home");
            //}
            //return NotFound("Ivalid Data");
        }
        //[HttpPost]
        //public async Task<IActionResult> AddToAdmin([FromForm]string Id)
        //{
        //    var user = await _userManager.FindByIdAsync(Id);
        //    await _userManager.AddToRoleAsync(user, "admin");
        //    return Ok();
            
        //}
        [Authorize]
        [HttpGet]
        public async Task<IActionResult>MyAccount()
        {
            var AccountUser = await _userManager.FindByNameAsync(User.Identity.Name);

            return View(AccountUser);
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> MyOrders()
        {
            var query = new GetMyOrdersQuery(User.Identity.Name);
            var result = await _mediator.Send(query);
            return View(result);
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            var command = new LogOutCommand();
            await _mediator.Send(command);
            return RedirectToAction("Index", "Home");
        }
       
    }
}
