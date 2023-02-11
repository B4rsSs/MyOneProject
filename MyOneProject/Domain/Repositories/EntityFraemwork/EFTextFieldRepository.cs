using Microsoft.EntityFrameworkCore;
using MyOneProject.Domain.Entities;
using MyOneProject.Domain.Repositories.Interfaces;

namespace MyOneProject.Domain.Repositories.EntityFraemwork
{
    public class EFTextFieldRepository : ITextFieldRepository
    {
        private readonly AppDbContext _context;

        public EFTextFieldRepository(AppDbContext context)
        {
            _context = context;
        }

        public void DeleteTextField(int id)
        {
            _context.TextFields.Remove(new TextField() { Id = id });
            _context.SaveChanges();
        }

        public TextField GetTextFieldById(int id)
        {
            return _context.TextFields.FirstOrDefault(x => x.Id == id);
        }

        public TextField GetTextFieldbyName(string codeWord)
        {
            return _context.TextFields.FirstOrDefault(x => x.CodeWord == codeWord);
        }

        public IQueryable<TextField> GetTextFields()
        {
            return _context.TextFields;
        }

        public void SaveTextField(TextField entity)
        {
            if (entity.Id == default)
                _context.Entry(entity).State = EntityState.Added;
            else
                _context.Entry(entity).State = EntityState.Modified;

            _context.SaveChanges();
            
        }
    }
}
