using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibraryProject.ViewModels
{
    public class AddBookVM
    {
        [Required]

        [Display(Name = " Title")]
        public string Title { get; set; }

        [Required]

        [Display(Name = " Author")]
        public string Author { get; set; }

        [Required]
        [Display(Name = " Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Book cover image URL")]
        public string ImageUrl { get; set; }

        [Required]

        [Display(Name = " Online Book")]
        public string OnlineBookUrl { get; set; }

        [Required]

        [Display(Name = " Genre")]
        public string GenreId { get; set; }

        public IEnumerable<GenreServiceVM> Genres { get; set; }
        public IEnumerable<AuthorServiceVM> Authors { get; set; }

    }
}
