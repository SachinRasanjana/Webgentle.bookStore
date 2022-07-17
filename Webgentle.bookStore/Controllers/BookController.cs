using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Webgentle.bookStore.Models;
using Webgentle.bookStore.Repositorys;

namespace Webgentle.bookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepsitory _bookRepository;

        public BookController()
        {
            _bookRepository = new BookRepsitory();
        }
        
        public ViewResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBook();
            return View();
        }

        public BookModel GetBookWithId(int id)
        {
            return _bookRepository.GetBookWithId(id);
        }

        public List<BookModel> GetBookWithName(string bookAuthor, string bookName)
        {
            return _bookRepository.GetBookWithName(bookAuthor, bookName);
        }
    }
}