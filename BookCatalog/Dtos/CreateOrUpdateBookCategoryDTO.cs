using System.ComponentModel.DataAnnotations;

namespace BookCatalog.Dtos
{
    public record CreateOrUpdateBookCategoryDTO
    {
        [Required]
        public string DescriptionCategory { get; set; }
    }
}
