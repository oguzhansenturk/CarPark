using CarPark.User.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarPark.User.Controllers
{
    public class UserController : Controller
    {
        private readonly IStringLocalizer<UserController> _localizer;

        public UserController(IStringLocalizer<UserController> localizer)
        {
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            var nameSurNameValue = _localizer["NameSurname"];
            return View();
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(UserCreateRequestModel requestModel)
        {
            return View(requestModel);
        }
    }
}
