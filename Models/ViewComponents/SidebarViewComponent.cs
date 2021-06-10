using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Company_Core.Domain;

namespace MVC_Company_Core.Models.ViewComponents
{
    public class SidebarViewComponent: ViewComponent
    {
        private readonly DataManager _dataManager;

        public SidebarViewComponent(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult((IViewComponentResult) View("Default", _dataManager.ServiceItems.GetServiceItems()));
        }
    }
}
