using BookCatalog.Models;

namespace BookCatalog.Repo
{
    public interface IAuthor
    {
        public Author CreateAuthor(Author author);
        public void UpdateAuthor(Guid id, Author newAuthor);
        public void DeleteAuthor(Guid id);

        public List<Author> GetAuthors();

        public Author GetAuthorById(Guid id);

        public Author GetAuthorByName(string name);
    }
}
