using BookCatalog.Models;

namespace BookCatalog.Repo
{
    public class AuthorRepo : IAuthor
    {
        private List<Author> _authors;
        public static AuthorRepo Instance;


        private AuthorRepo()
        {
            _authors = new List<Author>()
            {
                new Author() { Id = Guid.NewGuid(), NameAuthor = "J.R.R Tolkien" },
                new Author() { Id = Guid.NewGuid(), NameAuthor = "C.S Lewis"},
                new Author() { Id = Guid.NewGuid(), NameAuthor = "J.K Rowling"}
            };
        }

        public static AuthorRepo getInstance()
        {
            if (Instance == null)
            {
                Instance = new AuthorRepo();
            }
            return Instance;
        }


        public Author CreateAuthor(Author newAuthor)
        {
            newAuthor.Id = Guid.NewGuid();
            _authors.Add(newAuthor);

            return newAuthor;
        }

        public void DeleteAuthor(Guid id)
        {
            throw new NotImplementedException();
        }

        public Author GetAuthorById(Guid id)
        {
            return _authors.Find(author => author.Id == id);
        }

        public Author GetAuthorByName(string name)
        {

            return _authors.Find(author => author.NameAuthor.Equals(name));
        }

        public List<Author> GetAuthors()
        {
            return _authors;
        }

        public void UpdateAuthor(Guid id, Author newAuthor)
        {
            throw new NotImplementedException();
        }
    }
}
