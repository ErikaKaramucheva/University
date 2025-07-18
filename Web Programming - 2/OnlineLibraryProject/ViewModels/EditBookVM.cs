using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibraryProject.ViewModels
{
    public class EditBookVM:AddBookVM
    {
        [Required]
        public string Id { get; set; }

        public string CurrentAuthor { get; set; }
        public string CurrentGenre { get; set; }
    }
}
