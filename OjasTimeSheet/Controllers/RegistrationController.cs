using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ojas.TimeSheet.BusinessLayer;
using Ojas.TimeSheet.BusinessModel;

namespace OjasTimeSheet.Controllers
{
    public class RegistrationController : Controller
    {
        private IRegistrationBL _businessLayer;
        public RegistrationController(IRegistrationBL businessLayer)
        {
            _businessLayer = businessLayer;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PostUserRegistration(UserRegistrationModel data)
        {


            _businessLayer.RegisterUser(data);
            return View(true);
        }
    }
}