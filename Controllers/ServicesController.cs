using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Company_Core.Domain;

namespace MVC_Company_Core.Controllers
{
    public class ServicesController : Controller
    {
        private readonly DataManager _dataManager;

        public ServicesController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", _dataManager.ServiceItems.GetServiceItemById(id));
            }

            ViewBag.TextField = _dataManager.TextFields.GetTextFieldByCodeWord("PageServices");
            return View(_dataManager.ServiceItems.GetServiceItems());
        }
    }
}
