using BookCatalog.Models;
using Microsoft.EntityFrameworkCore;

namespace BookCatalog.Repo
{
    public class BookCategoryRepo : IBookCategory
    {

       
        public BookCategoryRepo()
        {

        }
        public BookCategory CreateBookCategory(string bookCategoryDescription)
        {
            throw new NotImplementedException();
        }

        public void DeleteBookCategory(Guid id)
        {
            throw new NotImplementedException();
        }

        public Book GetBookCategory(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<BookCategory> GetBooksCategories()
        {
            throw new NotImplementedException();
        }

        public BookCategory GetBookCategoryByDescription(string description)
        {

            throw new NotImplementedException();
        }


        public void UpdateBookCategory(Guid id, BookCategory bookCategory)
        {
            throw new NotImplementedException();
        }
    }
}
