using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdWeekHomework.Business.Interfaces;
using ThirdWeekHomework.Data.DTOs;
using ThirdWeekHomework.Data.Interfaces;
using ThirdWeekHomework.Domain.Entities;

namespace ThirdWeekHomework.Business.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly IRepository<Book> _repository;
        public LibraryService(IRepository<Book> repository)
        {
            _repository = repository;
        }

        public IQueryable<Book> GetAll()
        {
           return _repository.GetAll();
        }

        public Book GetBookById(int id)
        {
            return _repository.GetById(id);
        }

        public void Add(BookDTO bookDTO)
        {
            var book = new Book()
            {
                BookName = bookDTO.BookName,
                CreatedBy = bookDTO.CreatedBy,
                CreatedDate = bookDTO.CreatedDate,
                PageNumber = bookDTO.PageNumber
            };
            _repository.Add(book);
        }

        public void UpdateBook(BookDTO bookDTO)
        {
            var book = new Book()
            {   
                Id = bookDTO.Id,
                BookName = bookDTO.BookName,
                PageNumber = bookDTO.PageNumber,
                ModifiedBy = bookDTO.ModifiedBy,
                ModifiedDate = bookDTO.ModifiedDate
            };
            _repository.Update(book);
        }

        public void DeleteBook(Book book)
        {
            _repository.Remove(book);
        }
    }
}
