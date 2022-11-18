using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThirdWeekHomework.Business.Interfaces;
using ThirdWeekHomework.Data.DTOs;
using ThirdWeekHomework.Domain.Entities;

namespace ThirdWeekHomework.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryService _libraryService;

        public LibraryController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }
        [Route("InsertBook")]
        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            var bookDto = new BookDTO
            {
                BookName = book.BookName,
                PageNumber = book.PageNumber.Value,
                CreatedBy = Guid.NewGuid(),
                CreatedDate = System.DateTime.Now         
            };

            _libraryService.Add(bookDto);
            return Ok("Success");
        }
        [Route("GetBookById")]
        [HttpGet]
        public IActionResult GetBookById(int id)
        {
            var result = _libraryService.GetBookById(id);
            return Ok(result);
        }
        
        [Route("GetAllBooks")]
        [HttpGet]
        public IActionResult GetAllBooks()
        {
            var result = _libraryService.GetAll();
            return Ok(result);
        }

        [Route("UpdateBook")]
        [HttpPut]
        public IActionResult UpdateBook(Book book)
        {
            var bookDto = new BookDTO
            {
                Id = book.Id,
                BookName = book.BookName,
                PageNumber = book.PageNumber.Value,
                ModifiedBy = Guid.NewGuid(),
                ModifiedDate = System.DateTime.Now
            };
            _libraryService.UpdateBook(bookDto);
            return Ok("Success");
        }

        [Route("DeleteBook")]
        [HttpDelete]
        public IActionResult DeleteBook(Book book)
        {
            _libraryService.DeleteBook(book);
            return Ok("Succes");
        }
    }
}
