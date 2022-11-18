using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdWeekHomework.Data.DTOs;
using ThirdWeekHomework.Domain.Entities;

namespace ThirdWeekHomework.Business.Interfaces
{
    public interface ILibraryService
    {
        IQueryable<Book> GetAll();
        Book GetBookById(int id); 
        void Add(BookDTO bookDTO);
        void UpdateBook(BookDTO bookDTO);
        void DeleteBook(Book book);        
    }
}
