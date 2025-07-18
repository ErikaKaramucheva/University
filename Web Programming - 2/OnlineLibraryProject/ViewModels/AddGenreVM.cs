using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlineLibraryProject.ViewModels
{
    public class AddGenreVM
    {
        [Required]
        public string Name { get; set; }
    }
}
