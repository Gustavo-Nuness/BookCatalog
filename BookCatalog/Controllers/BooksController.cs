using BookCatalog.Dtos;
using BookCatalog.Models;
using BookCatalog.Repo;
using Microsoft.AspNetCore.Mvc;

namespace BookCatalog.Controllers
{
    [ApiController]
    [Route("books")]
    public class BooksController : ControllerBase
    {
        private IBook _BookRepo;
        private IBookCategory _BookCategory;
        private IAuthor _AuthorRepo;

        public BooksController()
        {
            _BookRepo = new BookRepo();
            _BookCategory = new BookCategoryRepo();
            _AuthorRepo = new AuthorRepo();
        }

        [HttpGet]
        public ActionResult<IEnumerable<BookDTO>> GetBooks()
        {
            return _BookRepo.GetBooks()
                .Select(book => new BookDTO { Id = book.Id, Title = book.Title, Price = book.Price, Category = book.Category, Authors = book.Authors })
                .ToList();
        }
        [HttpGet("{id}")]
        public ActionResult<BookDTO> GetBook(Guid id)
        {

            var book = _BookRepo.GetBook(id);

            if (book == null)
                return NotFound();

            var bookDTO = new BookDTO { Id = book.Id, Title = book.Title, Price = book.Price, Category = book.Category, Authors = book.Authors };

            return bookDTO;

        }

        [HttpGet("getBooksByAuthor/{idAuthor}")]
        public ActionResult<List<Book>> getBooksByAuthor(Guid idAuthor)
        {

             var result = _BookRepo.getBooksByAuthor(idAuthor);

            if (result.Count > 0)
                return result;
            else
                return NotFound();
        }

        

        
        [HttpPost]
        public ActionResult CreateBook(CreateOrUpdateBookDTO book)
        {
            var newBook = new Book();

            newBook.Id = Guid.NewGuid();
            newBook.Title = book.Title;
            newBook.Price = book.Price;
            newBook.Category.DescriptionCategory = book.Category.DescriptionCategory;

            foreach (var authorDto in book.Authors)
            {
                var searchResult = _AuthorRepo.GetAuthorByName(authorDto.NameAuthor);

                if (searchResult != null)
                {
                    newBook.Authors.Add(searchResult);
                }
                else
                {
                    Author author = _AuthorRepo.CreateAuthor(new Author() { NameAuthor = authorDto.NameAuthor });
                    newBook.Authors.Add(author);
                }

            }

            _BookRepo.CreateBook(newBook);

            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult UpdateBook(Guid id, CreateOrUpdateBookDTO updatedBook)
        {
            var oldBook = _BookRepo.GetBook(id);

            if (oldBook == null)
                return NotFound();

            oldBook.Title = updatedBook.Title;
            oldBook.Price = updatedBook.Price;
            var newCategory =
                _BookCategory.GetBookCategoryByDescription(updatedBook.Category.DescriptionCategory);

            if (newCategory != null)
            {
                oldBook.Category = newCategory;
            }
            else
            {
                oldBook.Category =
                    _BookCategory.CreateBookCategory(updatedBook.Category.DescriptionCategory);
            }

            Author oldAuthor = null;
            oldBook.Authors.Clear();
            
            foreach (var newAuthor in updatedBook.Authors)
            {
                oldAuthor = _AuthorRepo.GetAuthorByName(newAuthor.NameAuthor);

                if (oldAuthor != null)
                {
                    oldBook.Authors.Add(oldAuthor);
                }
                else
                {
                    var author = new Author() { NameAuthor = newAuthor.NameAuthor };
                    oldBook.Authors.Add(_AuthorRepo.CreateAuthor(author));
                }
            }

            _BookRepo.UpdateBook(id, oldBook);

            return Ok();
        }


        [HttpDelete("{id}")]
        public ActionResult DeleteBook(Guid id)
        {
            var delectedBook = _BookRepo.GetBook(id);

            if (delectedBook == null)
                return NotFound();

            _BookRepo.DeleteBook(id);

            return Ok();

        }




    }
}
