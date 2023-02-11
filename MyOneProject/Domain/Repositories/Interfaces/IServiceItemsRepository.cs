using MyOneProject.Domain.Entities;

namespace MyOneProject.Domain.Repositories.Interfaces
{
    public interface IServiceItemsRepository
    {
        IQueryable<ServiceItem> GetServiceItems();
        ServiceItem GetServiceItemById(int id);
        void SaveServiceItem(ServiceItem entity);
        void DeleteServiceItem(int id);
    }
}
