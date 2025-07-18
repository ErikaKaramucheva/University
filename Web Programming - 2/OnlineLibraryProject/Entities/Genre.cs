using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlineLibraryProject.Entities
{
    public class Genre:BaseEntity
    {
        public Genre():base()
        {
            Books = new HashSet<Book>();
        }


        [Required]
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
