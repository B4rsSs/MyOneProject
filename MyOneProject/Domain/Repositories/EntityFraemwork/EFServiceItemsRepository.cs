using Microsoft.EntityFrameworkCore;
using MyOneProject.Domain.Entities;
using MyOneProject.Domain.Repositories.Interfaces;

namespace MyOneProject.Domain.Repositories.EntityFraemwork
{
    public class EFServiceItemsRepository : IServiceItemsRepository
    {
        private readonly AppDbContext _context;

        public EFServiceItemsRepository(AppDbContext context)
        {
            _context = context;
        }

        public void DeleteServiceItem(int id)
        {
            _context.ServiceItems.Remove(new ServiceItem() { Id = id });
            _context.SaveChanges();
        }

        public ServiceItem GetServiceItemById(int id)
        {
            return _context.ServiceItems.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<ServiceItem> GetServiceItems()
        {
            return _context.ServiceItems;
        }

        public void SaveServiceItem(ServiceItem entity)
        {
            if (entity.Id == default)
                _context.Entry(entity).State = EntityState.Added;
            else
                _context.Entry(entity).State = EntityState.Modified;

            _context.SaveChanges();
        }
    }
}
