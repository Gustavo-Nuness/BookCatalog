using System.ComponentModel.DataAnnotations;

namespace BookCatalog.Models
{
    public class BookCategory
    {   
        [Required]
        public Guid IdBookCategory { get; set; }
        [Required]
        public string DescriptionCategory { get; set; }

    }
}
