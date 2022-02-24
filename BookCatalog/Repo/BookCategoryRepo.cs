using BookCatalog.Models;

namespace BookCatalog.Repo
{
    public class BookCategoryRepo : IBookCategory
    {
        private List<BookCategory> _bookCategories;
        
        public BookCategoryRepo()
        {
            _bookCategories = new List<BookCategory>();

            _bookCategories.Add(new BookCategory() { IdBookCategory = Guid.NewGuid(),
                DescriptionCategory = "Romance" });

            _bookCategories.Add(new BookCategory() { IdBookCategory = Guid.NewGuid(),
                DescriptionCategory = "Ficção científica"  });

            _bookCategories.Add(new BookCategory()
            {
                IdBookCategory = Guid.NewGuid(),
                DescriptionCategory = "Fantasia"
            });
        }

        public BookCategory CreateBookCategory(string bookCategoryDescription)
        {
            var newBookCategory = new BookCategory();
            newBookCategory.IdBookCategory = Guid.NewGuid();
            newBookCategory.DescriptionCategory = bookCategoryDescription;

            _bookCategories.Add(newBookCategory);

            return newBookCategory;
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
            return _bookCategories;
        }

        public BookCategory GetBookCategoryByDescription(string description)
        {

             var category = _bookCategories.Where(
                 bookCategory => bookCategory.DescriptionCategory.Equals(description))
                .SingleOrDefault();
             return category;
        }


        public void UpdateBookCategory(Guid id, BookCategory bookCategory)
        {
            throw new NotImplementedException();
        }
    }
}
