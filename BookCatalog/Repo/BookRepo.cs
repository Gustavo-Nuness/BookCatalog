using BookCatalog.Models;
using Microsoft.EntityFrameworkCore;

namespace BookCatalog.Repo
{
    public class BookRepo : DbContext, IBook
    {
        private IBookCategory _bookCategoryRepo;
        private IAuthor _authorRepo;

        public DbSet<Book> books { get; set; }

        public BookRepo() 
        {
            _bookCategoryRepo = new BookCategoryRepo();
            _authorRepo = new AuthorRepo();

        }

        public BookRepo (DbContextOptions<BookRepo> optionsDatabase) : base(optionsDatabase)
        {
            _bookCategoryRepo = new BookCategoryRepo();
            _authorRepo = new AuthorRepo();

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

            books.Add(book);
        }

        public void DeleteBook(Guid id)
        {
            //var bookIndex = books.FindIndex(x => x.Id == id);
            //if (bookIndex > -1)
                //books.RemoveAt(bookIndex);
        }

        public Book GetBook(Guid id)
        {
            var book = books.Where(x => x.Id == id).SingleOrDefault();
            return book;
        }

        public List<Book> getBooksByAuthor(Guid idAuthor)
        {
            //Author author = _authorRepo.GetAuthorById(idAuthor);
            //List<Book> books = books.Where(book => book.Authors.IndexOf(author) > -1).ToList();
            return null;
        }

        public IEnumerable<Book> GetBooks()
        {
            return books;

        }

        public void UpdateBook(Guid id, Book book)
        {

            //var bookIndex = books.FindIndex(x => x.Id == id);
            //if (bookIndex > -1)
              //  books[bookIndex] = book;

        }
    }
}
