using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineLibraryProject.Entities
{
    public class Transaction:BaseEntity
    {
        [Required]
        [ForeignKey("UserId")]
        public string UserId { get; set; }
        [Required]
        [ForeignKey("BookId")]
        public string BookId { get; set; }
    }
}
