using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Routing;
using Webgentle.bookStore.Models;

namespace Webgentle.bookStore.Repositorys
{
    public class BookRepsitory
    {
        public List<BookModel> GetAllBook()
        {
            return DataSource();
        }

        public BookModel GetBookId(int id)
        {
            return DataSource().FirstOrDefault(x => x.Id == id);
        }

        public List<BookModel> SearchBook(string bookAuthor, string bookName)
        {
            return DataSource().Where(x => x.Title.Equals(bookName,StringComparison.OrdinalIgnoreCase) || x.Author.Equals(bookAuthor,StringComparison.OrdinalIgnoreCase)).ToList();
        }
        
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id = 1, Title = "One", Author = "Alfa" },
                new BookModel() { Id = 2, Title = "Two", Author = "Bravo" },
                new BookModel() { Id = 3, Title = "Three", Author = "Charly" },
                new BookModel() { Id = 4, Title = "Four", Author = "Delta" },
                new BookModel() { Id = 5, Title = "Five", Author = "Echo" },
            };

        }
    }
}