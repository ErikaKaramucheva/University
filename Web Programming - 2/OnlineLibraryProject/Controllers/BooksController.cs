using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using OnlineLibraryProject.Entities;
using OnlineLibraryProject.Entities.Repositories;
using OnlineLibraryProject.Services;
using static OnlineLibraryProject.Entities.Notifications;
using static OnlineLibraryProject.Entities.ErrorMessages;
using OnlineLibraryProject.ViewModels;

namespace OnlineLibraryProject.Controllers
{
    public class BooksController : Controller
    {
        private readonly LibraryDbContext _context;
        private readonly IBooksService _booksService;
        private readonly IMemoryCache _cache;

        public BooksController(LibraryDbContext context,IBooksService booksService,IMemoryCache memoryCache)
        {
            _context = context;
            _booksService = booksService;
            _cache = memoryCache;
        }

        public IActionResult All([FromQuery] int currentPage)
        {
            var allBooksServiceModel = _booksService.GetAllBooks(currentPage);

            if (allBooksServiceModel.Books?.Count() == 0)
                ModelState.AddModelError(String.Empty, NoBooksFound);

            return View(allBooksServiceModel);
        }

        public IActionResult Details([FromQuery] string bookId)
        {
            var bookDetailsServiceModel = _booksService.GetBookDetails
                (bookId);

            if (bookDetailsServiceModel == null)
                ModelState.AddModelError(String.Empty, BookNotFound);

            return View(bookDetailsServiceModel);
        }

        public IActionResult AddBook()
        {
            var addBookFormModel = new AddBookVM()
            { Genres = _booksService.GetAllGenresServiceModels() };

            if (addBookFormModel.Genres?.Count() < 1)
                ModelState.AddModelError(String.Empty, SomethingWentWrong);

            return View(addBookFormModel);
        }

        [HttpPost]
        public IActionResult AddBook(AddBookVM addBookFormModel)
        {
            //var genres = GetGenresAndSetCacheIfNeeded();

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(String.Empty, SomethingWentWrong);
                //addBookFormModel.Genres = genres;

                return View("AddBook", addBookFormModel);
            }

            var results = _booksService
                .AddBookAndReturnBooleans(addBookFormModel);

            if (results.doesTitleExistsInDb)
                ModelState.AddModelError(String.Empty, TitleAlreadyExists);

            if (results.genreDoesNotExistsInDb)
                ModelState.AddModelError(String.Empty, GenreDoesNotExists);

            if (ModelState.ErrorCount > 0)
            {
                //addBookFormModel.Genres = genres;
                return View("AddBook", addBookFormModel);
            }

            TempData[SuccessfullyAddedBookKey] = SuccessfullyAddedBook;

            return RedirectToAction(nameof(All));
        }

        public IActionResult EditBook(string bookId)
        {
            var editBookFormModel = _booksService.GetEditBookFormModel(bookId);

            if (editBookFormModel == null)
                ModelState.AddModelError(String.Empty, BookNotFound);

            return View(editBookFormModel);
        }

        [HttpPost]
        public IActionResult Edit(EditBookVM editBookFormModel)
        {
           // var genres = GetGenresAndSetCacheIfNeeded();

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(String.Empty, SomethingWentWrong);
               // editBookFormModel.Genres = genres;

                return View("EditBook", editBookFormModel);
            }

            var results = _booksService.EditBookAndReturnBooleans(editBookFormModel);

            if (results.bookDoesNotExistsInDb)
                ModelState.AddModelError(String.Empty, BookNotFound);

            if (results.genreDoesNotExistsInDb)
                ModelState.AddModelError(String.Empty, GenreDoesNotExists);

            if (ModelState.ErrorCount > 0)
            {
               // editBookFormModel.Genres = genres;
                return View("EditBook", editBookFormModel);
            }

            TempData[SuccessfullyEditedBookKey] = SuccessfullyEditedBook;

            return RedirectToAction(nameof(All));
        }

        public IActionResult Delete([FromQuery] string bookId)
        {
            var isBookDeleted = _booksService.DeleteBookAndReturnBoolean(bookId);

            if (!isBookDeleted)
            {
                TempData[UnsuccessfullyDeletedBookKey] = UnsuccessfullyDeletedBook;

                return RedirectToAction(nameof(All));
            }

            TempData[SuccessfullyDeletedBookKey] = SuccessfullyDeletedBook;

            return RedirectToAction(nameof(All));
        }

        public IActionResult MyLibrary([FromQuery] int currentPage, string userId)
        {
            var allBooksServiceModel = _booksService
                .GetMyLibrary(currentPage, userId);

            if (allBooksServiceModel.Books?.Count() == 0)
                ModelState.AddModelError(String.Empty, NoBooksFound);

            return View(allBooksServiceModel);
        }

       /* private List<GenreServiceVM> GetGenresAndSetCacheIfNeeded()
        {
            var genres = _cache.Get<List<GenreServiceVM>>(GenresCacheKey);

            if (genres == null)
            {
                genres = _booksService.GetAllGenresServiceModels();

                var cacheOptions = new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(TimeSpan.FromSeconds(30));

                _cache.Set(GenresCacheKey, genres, cacheOptions);
            }

            return genres;
        }*/
    }
}
