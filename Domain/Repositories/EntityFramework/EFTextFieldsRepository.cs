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
    public class EFTextFieldsRepository : ITextFieldsRepository
    {
        private readonly AppDbContext _context;
        public EFTextFieldsRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<TextField> GetTextFields() => _context.TextFields;

        public TextField GetTextFieldById(Guid id) =>
            _context.TextFields.FirstOrDefault(textField => textField.Id == id);

        public TextField GetTextFieldByCodeWord(string codeWord) =>
            _context.TextFields.FirstOrDefault(textField => textField.CodeWord == codeWord);

        public void SaveTextField(TextField entity)
        {
            _context.Entry(entity).State = entity.Id == default ? EntityState.Added : EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteTextField(Guid id)
        {
            _context.TextFields.Remove(new TextField() {Id = id});
            _context.SaveChanges();
        }
    }
}
