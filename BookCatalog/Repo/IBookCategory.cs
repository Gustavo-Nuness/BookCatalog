using BookCatalog.Models;

namespace BookCatalog.Repo
{
    public interface IBookCategory
    {
        public BookCategory CreateBookCategory(string bookCategory);

        public List<BookCategory> GetBooksCategories();

        public Book GetBookCategory(Guid id);

        public void UpdateBookCategory(Guid id, BookCategory bookCategory);

        public void DeleteBookCategory(Guid id);

        public BookCategory GetBookCategoryByDescription(string description);
    }
}
