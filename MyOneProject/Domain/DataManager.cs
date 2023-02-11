using MyOneProject.Domain.Repositories.Interfaces;

namespace MyOneProject.Domain
{
    public class DataManager
    {
        public ITextFieldRepository TextField { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }

        public DataManager(ITextFieldRepository textFieldRepository, IServiceItemsRepository serviceItemsRepository)
        {
            TextField = textFieldRepository;
            ServiceItems = serviceItemsRepository;
        }
    }
}
