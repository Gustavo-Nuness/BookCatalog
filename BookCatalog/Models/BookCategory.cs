﻿using System.ComponentModel.DataAnnotations;

namespace BookCatalog.Models
{
    public class BookCategory
    {   
        [Required]
        [Key]
        public Guid IdBookCategory { get; set; }
        [Required]
        public string DescriptionCategory { get; set; }

    }
}
