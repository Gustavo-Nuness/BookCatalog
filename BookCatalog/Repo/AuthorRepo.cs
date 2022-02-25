using BookCatalog.Models;
using Microsoft.EntityFrameworkCore;

namespace BookCatalog.Repo
{
    public class AuthorRepo : IAuthor
    {
       


        public AuthorRepo()
        {
 
        }

        public Author CreateAuthor(Author newAuthor)
        {
            throw new NotImplementedException();
        }

        public void DeleteAuthor(Guid id)
        {
            throw new NotImplementedException();
        }

        public Author GetAuthorById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Author GetAuthorByName(string name)
        {

            throw new NotImplementedException();
        }

        public List<Author> GetAuthors()
        {
            throw new NotImplementedException();
        }

        public void UpdateAuthor(Guid id, Author newAuthor)
        {
            throw new NotImplementedException();
        }
    }
}
