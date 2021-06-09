using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Company_Core.Domain.Entities;
using MVC_Company_Core.Domain.Repositories.Abstract;

namespace MVC_Company_Core.Domain.Repositories.EntityFramework
{
    public class EFServiceItemsRepository : IServiceItemsRepository
    {
        private readonly AppDbContext _context;

        public EFServiceItemsRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<ServiceItem> GetServiceItems() => _context.ServiceItems;

        public ServiceItem GetServiceItemById(Guid id) =>
            _context.ServiceItems.FirstOrDefault(serviceItem => serviceItem.Id == id);

        public void SaveServiceItem(ServiceItem entity)
        {
            _context.Entry(entity).State = entity.Id == default ? EntityState.Added : EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteServiceItem(Guid id)
        {
            _context.ServiceItems.Remove(new ServiceItem() {Id = id});
            _context.SaveChanges();
        }
    }
}
