using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using static OnlineLibraryProject.Entities.GlobalConstants;

namespace OnlineLibraryProject.Entities
{
    public class Book:BaseEntity
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string AuthorId { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [RegularExpression(UrlRegex)]
        public string ImageUrl { get; set; }

        [Required]
        public string GenreId { get; set; }

        [Required]
        [RegularExpression(UrlRegex)]
        public string OnlineBookUrl { get; set; }

    }
}
