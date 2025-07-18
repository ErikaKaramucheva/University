using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static OnlineLibraryProject.Entities.Paging;

namespace OnlineLibraryProject.ViewModels
{
    public class AllBookVM
    {
        //for taking all the books and arranging them by pages
        public AllBookVM() => CurrentPage = CurrentPageStart;

        public int CurrentPage { get; set; }

        public double MaxPage { get; set; }

        public IEnumerable<BookListingVM> Books { get; set; }

    }
}
