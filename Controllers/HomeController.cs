using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Company_Core.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MVC_Company_Core.Domain;

namespace MVC_Company_Core.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager _dataManager;

        public HomeController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View(_dataManager.TextFields.GetTextFieldByCodeWord("PageIndex"));
        }

        public IActionResult Contacts()
        {
            return View(_dataManager.TextFields.GetTextFieldByCodeWord("PageContacts"));
        }
    }
}
