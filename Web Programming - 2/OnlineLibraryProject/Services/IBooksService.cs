using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineLibraryProject.ViewModels;

namespace OnlineLibraryProject.Services
{
    public interface IBooksService
    {
        AllBookVM GetAllBooks(int currentPage);

        BookDetailsVM GetBookDetails(string bookId);

        List<GenreServiceVM> GetAllGenresServiceModels();

        AllBookVM GetMyLibrary(int currentPage, string userId);

        (bool doesTitleExistsInDb, bool genreDoesNotExistsInDb) AddBookAndReturnBooleans
            (AddBookVM addBookFormModel);

        EditBookVM GetEditBookFormModel(string bookId);

        (bool bookDoesNotExistsInDb, bool genreDoesNotExistsInDb)
            EditBookAndReturnBooleans(EditBookVM editBookFormModel);

        bool DeleteBookAndReturnBoolean(string bookId);
    }
}

