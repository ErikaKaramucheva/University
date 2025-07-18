using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlineLibraryProject.Entities
{
    public class Author:BaseEntity
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
