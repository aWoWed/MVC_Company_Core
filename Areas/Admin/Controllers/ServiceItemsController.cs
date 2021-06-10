using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.CodeAnalysis.Differencing;
using Microsoft.EntityFrameworkCore;
using MVC_Company_Core.Domain;
using MVC_Company_Core.Domain.Entities;
using MVC_Company_Core.Service;

namespace MVC_Company_Core.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceItemsController : Controller
    {
        private readonly DataManager _dataManager;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ServiceItemsController(DataManager dataManager, IWebHostEnvironment hostEnvironment)
        {
            _dataManager = dataManager;
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new ServiceItem() : _dataManager.ServiceItems.GetServiceItemById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(ServiceItem model, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    model.TitleImagePath = titleImageFile.FileName;
                    using (var stream = new FileStream(Path.Combine(_hostEnvironment.WebRootPath, "images/", titleImageFile.FileName), FileMode.Create))
                    {
                        titleImageFile.CopyTo(stream);
                    }
                }
                _dataManager.ServiceItems.SaveServiceItem(model); 
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }

            return View(model);
        } 

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            _dataManager.ServiceItems.DeleteServiceItem(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}
