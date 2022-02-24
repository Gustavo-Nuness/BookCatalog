using BookCatalog.Models;
using System.ComponentModel.DataAnnotations;

namespace BookCatalog.Dtos
{
    public record CreateOrUpdateBookDTO
    {
        [Required]
        public string Title { get; set; }
        [Required]
        [Range(1, 100)]
        public decimal Price { get; set; }
        [Required]
        public CreateOrUpdateBookCategoryDTO Category { get; set; }

        public List<CreateOrUpdateAuthorDTO> Authors { get; set; }

        public CreateOrUpdateBookDTO()
        {
            Category = new CreateOrUpdateBookCategoryDTO();
            Authors = new List<CreateOrUpdateAuthorDTO>();
        }

        
    }
}

