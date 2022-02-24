using BookCatalog.Models;

namespace BookCatalog.Repo
{
    public class BookRepo : IBook
    {
        private List<Book> _books;
        private IBookCategory _bookCategoryRepo;
        private IAuthor _authorRepo;
        

        public BookRepo(IBookCategory bookCategoryRepo)
        {
            _bookCategoryRepo = bookCategoryRepo;
            _authorRepo = AuthorRepo.getInstance();
         
            _books = new()
            {
                new Book
                {
                    Id = Guid.NewGuid(),
                    Title = "O Senhor dos anéis",
                    Price = 60,
                    Category = _bookCategoryRepo.GetBookCategoryByDescription("Fantasia"),

                }

            };
            var teste = _authorRepo.GetAuthorByName("J.R.R Tolkien");
            _books[0].Authors.Add(_authorRepo.GetAuthorByName("J.R.R Tolkien"));


        }
        public void CreateBook(Book book)
        {
            BookCategory category =
                _bookCategoryRepo.GetBookCategoryByDescription(book.Category.DescriptionCategory);

            if (category == null)
            {
                book.Category = _bookCategoryRepo.CreateBookCategory(book.Category.DescriptionCategory);
            }
            else
            {
                book.Category = category;
            }

            _books.Add(book);
        }

        public void DeleteBook(Guid id)
        {
            var bookIndex = _books.FindIndex(x => x.Id == id);
            if (bookIndex > -1)
                _books.RemoveAt(bookIndex);
        }

        public Book GetBook(Guid id)
        {
            var book = _books.Where(x => x.Id == id).SingleOrDefault();
            return book;
        }

        public List<Book> getBooksByAuthor(Guid idAuthor)
        {
            Author author = _authorRepo.GetAuthorById(idAuthor);
            List<Book> books = _books.Where(book => book.Authors.IndexOf(author) > -1).ToList();
            return books;
        }

        public IEnumerable<Book> GetBooks()
        {
            return _books;

        }

        public void UpdateBook(Guid id, Book book)
        {

            var bookIndex = _books.FindIndex(x => x.Id == id);
            if (bookIndex > -1)
                _books[bookIndex] = book;

        }
    }
}
