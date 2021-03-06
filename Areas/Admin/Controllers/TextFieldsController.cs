using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Company_Core.Domain;
using MVC_Company_Core.Domain.Entities;
using MVC_Company_Core.Service;

namespace MVC_Company_Core.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TextFieldsController : Controller
    {
        private readonly DataManager _dataManager;

        public TextFieldsController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public IActionResult Edit(string codeWord)
        {
            var entity = _dataManager.TextFields.GetTextFieldByCodeWord(codeWord);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(TextField model)
        {
            if (ModelState.IsValid)
            {
                _dataManager.TextFields.SaveTextField(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }
    }
}
