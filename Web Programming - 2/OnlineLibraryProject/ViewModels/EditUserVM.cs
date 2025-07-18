using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibraryProject.ViewModels
{
    public class EditUserVM:AddUserVM
    {
        [Required]
        public string Id { get; set; }
    }
}
