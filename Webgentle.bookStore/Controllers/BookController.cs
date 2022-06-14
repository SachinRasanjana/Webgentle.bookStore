using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Webgentle.bookStore.Models;
using Webgentle.bookStore.Repositorys;

namespace Webgentle.bookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepsitory _bookRepository = null;

        public BookController()
        {
            _bookRepository = new BookRepsitory();
        }
        
        public List<BookModel> GetAllBooks()
        {
            return _bookRepository.GetAllBook();
        }

        public BookModel GetBookWithId(int id)
        {
            return _bookRepository.GetBookId(id);
        }

        public List<BookModel> GetBookWithName(string bookAuthor, string bookName)
        {
            return _bookRepository.SearchBook(bookAuthor, bookName);
        }
    }
}