using BookCatalog.Models;
using BookCatalog.Repo;
using Microsoft.AspNetCore.Mvc;

namespace BookCatalog.Controllers
{
    [ApiController]
    [Route("categories")]
    public class BookCategoryController : ControllerBase
    {
        private IBookCategory _BookCategoryRepo;

        public BookCategoryController(IBookCategory bookCategory)
        {
            _BookCategoryRepo = bookCategory;
        }
        [HttpGet]
        public ActionResult<List<BookCategory>> GetBookCategories()
        {
            return _BookCategoryRepo.GetBooksCategories();
        }

        
        [HttpGet("{description}")]
        public ActionResult<BookCategory> GetBookCategoryByDescription(string description)
        {
            BookCategory bookCategory= _BookCategoryRepo.GetBookCategoryByDescription(description);

            if ( bookCategory == null )  
                return NotFound();

            return bookCategory;
        }
        
        

    }
}
