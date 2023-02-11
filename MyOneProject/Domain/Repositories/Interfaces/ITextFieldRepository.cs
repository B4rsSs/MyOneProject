using MyOneProject.Domain.Entities;

namespace MyOneProject.Domain.Repositories.Interfaces
{
    public interface ITextFieldRepository
    {
        IQueryable<TextField> GetTextFields();
        TextField GetTextFieldById(int id);
        TextField GetTextFieldbyName(string codeWord);
        void SaveTextField(TextField entity);
        void DeleteTextField(int id);
    }
}
