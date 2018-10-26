using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WarriorProof.Models;
using Microsoft.AspNetCore.Http;
using WarriorProof.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using AutoMapper;
using WarriorProof.Contacts.Models;
using WarriorProof.Mappings;
using WarriorProof.Contacts.Interfaces.Services;
using WarriorProof.Contacts.Enumerations;

namespace WarriorProof.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly IUserService _userService;

        public RegistrationController(IUserService userService)
        {
            _userService = userService;
        }
       
        [HttpGet]
        public IActionResult PersonalInformation()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult PersonalInformation(PersonalInfoViewModel model)
        {
            if (TryValidateModel(model))
            {
                HttpContext.Session.SetObjectAsJson("PersonalInfo", model);
                return View("CompanyInformation");
            }
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult CompanyInformation(CompanyInfoViewModel model)
        {
            if (TryValidateModel(model))
            {
                HttpContext.Session.SetObjectAsJson("CompanyInfo", model);
                ViewBag.LineOfBusinesses = GetLineOfBusinesses();
                return View("TrucksInformation");
            }
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult TrucksInformation(TrucksInfoViewModel model)
        {
            if (TryValidateModel(model))
            {
                HttpContext.Session.SetObjectAsJson("TrucksInfo", model);
                return View("LoginInformation");
            }
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult LoginInformation(LoginInfoViewModel model)
        {
            if (TryValidateModel(model))
            {
                var registrationData = new RegistrationViewModel
                {
                    PersonalInfo = HttpContext.Session.GetObjectFromJson<PersonalInfoViewModel>("PersonalInfo"),
                    CompanyInfo = HttpContext.Session.GetObjectFromJson<CompanyInfoViewModel>("CompanyInfo"),
                    TrucksInfo = HttpContext.Session.GetObjectFromJson<TrucksInfoViewModel>("TrucksInfo"),
                    LoginInfo = model
                };
                var warriorUser = registrationData.ToWarriorUser();
                warriorUser = _userService.CreateUser(warriorUser);
                return View("Summary", registrationData);
            }
            return View(model);

        }

        private List<SelectListItem> GetLineOfBusinesses()
        {
            return Enum.GetValues(typeof(LineOfBusiness)).Cast<LineOfBusiness>().Select(v => new SelectListItem
            {
                Text = v.ToString(),
                Value = ((int)v).ToString()
            }).ToList();
        }
    }
}
