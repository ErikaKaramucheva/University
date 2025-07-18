using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibraryProject.ViewModels
{
    public class BookDetailsVM
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Genre { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }
        public string OnlineBookUrl { get; set; }
    }
}
