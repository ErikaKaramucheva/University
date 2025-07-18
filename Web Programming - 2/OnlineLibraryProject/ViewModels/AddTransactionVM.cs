using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibraryProject.ViewModels
{
    public class AddTransactionVM
    {
        //add book to myLibrary
        public string Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public string BookId { get; set; }
        //store all books by their id and Title
        public IEnumerable<BookServiceVM> Books { get; set; }
    }
}
