using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibraryProject.ViewModels
{
    public class BookListingVM
    {
        //info that we display in All books View
        public string Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string ImageUrl { get; set; }
        public string OnlineBookUrl { get; set; }
    }
}
