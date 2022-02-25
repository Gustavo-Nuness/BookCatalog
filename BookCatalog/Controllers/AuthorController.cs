using BookCatalog.Models;
using BookCatalog.Repo;
using Microsoft.AspNetCore.Mvc;

namespace BookCatalog.Controllers
{
    [ApiController]
    [Route("authors")]
    public class AuthorController : ControllerBase
    {
        private IAuthor authorRepo;

        public AuthorController()
        {
            authorRepo = new AuthorRepo();
        }

        [HttpGet]
        public ActionResult<List<Author>> GetAuthors()
        {
            return authorRepo.GetAuthors();
        }

        [HttpGet("{nameAuthor}")]
        public ActionResult<Author> GetAuthorByName(string nameAuthor)
        {
            Author authorFinded = authorRepo.GetAuthorByName(nameAuthor);

            if (authorFinded == null)
                return NotFound();

            return authorFinded;
        }


    }
}
