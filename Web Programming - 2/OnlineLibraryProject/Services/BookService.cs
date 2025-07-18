using OnlineLibraryProject.Entities;
using OnlineLibraryProject.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static OnlineLibraryProject.Entities.Paging;
using static OnlineLibraryProject.Entities.Notifications;
using static OnlineLibraryProject.Entities.ErrorMessages;
using OnlineLibraryProject.ViewModels;
using Ganss.Xss;

namespace OnlineLibraryProject.Services
{
    public class BookService:IBooksService
    {
        private readonly LibraryDbContext _data;

        public BookService(LibraryDbContext data) => _data = data;

        //calculates how many pages with books we have
        private double GetMaxPage(int count) =>
           Math.Ceiling
               (count * 1.00 / FourCardsPerPage * 1.00);

        public AllBookVM GetAllBooks(int currentPage)
        {
            var booksQuery = _data.Books.AsQueryable();
            var booksCount = booksQuery.Count();
            var maxPage = GetMaxPage(booksCount);

            currentPage =
                CheckIfCurrentPageIsOutOfRangeAndReturnCurrentPageStart
                    (currentPage, maxPage);

            return GetAllBooksQueryModel(currentPage, maxPage, (IQueryable<Book>)booksQuery);
        }

        private int
            CheckIfCurrentPageIsOutOfRangeAndReturnCurrentPageStart
            (int currentPage, double maxPage)
        {
            if (currentPage > maxPage || currentPage < 1)
            {
                return CurrentPageStart;
            }
            else
            {
                return currentPage;
            }
        }

        private static AllBookVM GetAllBooksQueryModel
       (int currentPage, double maxPage, IQueryable<Book> booksQuery)
        {
            var result = new AllBookVM();

            result.CurrentPage = currentPage;
            result.MaxPage = maxPage;
            result.Books = GetAllBooksListingModels
                  (booksQuery
                      .Skip((currentPage - 1) * FourCardsPerPage)
                      .Take(FourCardsPerPage));
            return result;
        }

        public BookDetailsVM GetBookDetails(string bookId)
        {
            var book = GetBookFromDb(bookId);

            if (book == null)
                return null;

            var genre = GetGenreFromDb(book.GenreId).Name;
            var firstName = GetAuthorFromDb(book.AuthorId).FirstName;
            var lastName = GetAuthorFromDb(book.AuthorId).LastName;
            var author = firstName + " " + lastName;

            return GetBookDetailsServiceModel(book, genre,author);
        }

        private static BookDetailsVM
    GetBookDetailsServiceModel(Book book, string genre,string author)
        {
            var result = new BookDetailsVM()
            {
                Id = book.Id,
                Title = book.Title,
                Author = author,
                Genre = genre,
                ImageUrl = book.ImageUrl,
                Description = book.Description,
                OnlineBookUrl = book.OnlineBookUrl
            };
            return result;
        }

        public List<GenreServiceVM> GetAllGenresServiceModels()
            => _data
                .Genres
                .Select(g => new GenreServiceVM()
                {
                    Id = g.Id,
                    Name = g.Name
                })
                .ToList();

        public AllBookVM GetMyLibrary(int currentPage, string userId)
        {
            var userBook = _data
                .Transactions
                .Where(b => b.UserId == userId)
                .Select(b => b.BookId)
                .ToList();
            var booksQuery = _data
                .Books
                .Where(b => userBook.Contains(b.Id))
                .AsQueryable();
            var booksCount = booksQuery.Count();
            var maxPage = GetMaxPage(booksCount);
            currentPage =
                CheckIfCurrentPageIsOutOfRangeAndReturnCurrentPageStart
                    (currentPage, maxPage);

            return GetAllBooksQueryModel(currentPage, maxPage, (IQueryable<Book>)booksQuery);
        }

        public (bool doesTitleExistsInDb, bool genreDoesNotExistsInDb) AddBookAndReturnBooleans
            (AddBookVM addBookFormModel)
        {
            var doesTitleExistsInDb = false;
            var genreDoesNotExistsInDb = false;
            var htmlSanitizer = new HtmlSanitizer();
            var title = htmlSanitizer.Sanitize(addBookFormModel.Title).Trim();

            if (_data.Books.Any(b => b.Title == title))
            {
                doesTitleExistsInDb = true;
                return (doesTitleExistsInDb, genreDoesNotExistsInDb);
            }

            var genreId = htmlSanitizer.Sanitize(addBookFormModel.GenreId);
            var authorId = htmlSanitizer.Sanitize(addBookFormModel.Author);

            if (!CheckIfGenreExistsInDb(genreId))
            {
                genreDoesNotExistsInDb = true;
                return (doesTitleExistsInDb, genreDoesNotExistsInDb);
            }

            var newBook = FillBookDbModelWithDataAndReturnIt
                (addBookFormModel, genreId, authorId, title, htmlSanitizer);
            _data.Books.Add(newBook);
            _data.SaveChanges();

            return (doesTitleExistsInDb, doesTitleExistsInDb);
        }
        public EditBookVM GetEditBookFormModel(string bookId)
        {
            var book = GetBookFromDb(bookId);

            if (book == null)
                return null;

            var genre = GetGenreFromDb(book.GenreId).Name;
            var firstName = GetAuthorFromDb(book.AuthorId).FirstName;
                var lastName=GetAuthorFromDb(book.AuthorId).LastName;
            var author = firstName + " " + lastName;

            return GetEditBookFormModel(book, genre,author);
        }

        public (bool bookDoesNotExistsInDb, bool genreDoesNotExistsInDb)
            EditBookAndReturnBooleans(EditBookVM editBookFormModel)
        {
            var bookDoesNotExistsInDb = false;
            var genreDoesNotExistsInDb = false;

            var book = GetBookFromDb(editBookFormModel.Id);

            if (book == null)
            {
                bookDoesNotExistsInDb = true;
                return (bookDoesNotExistsInDb, genreDoesNotExistsInDb);
            }

            var htmlSanitizer = new HtmlSanitizer();
            var genreId = htmlSanitizer.Sanitize(editBookFormModel.GenreId);
            var authorId = htmlSanitizer.Sanitize(editBookFormModel.Author);

            if (!CheckIfGenreExistsInDb(genreId))
            {
                genreDoesNotExistsInDb = true;
                return (bookDoesNotExistsInDb, genreDoesNotExistsInDb);
            }


            UpdateBookDbModelAndSaveChanges(book, genreId, editBookFormModel, htmlSanitizer,authorId);

            return (bookDoesNotExistsInDb, genreDoesNotExistsInDb);
        }

        public bool DeleteBookAndReturnBoolean(string bookId)
        {
            var book = GetBookFromDb(bookId);

            if (book == null)
                return false;

            _data.Books.Remove(book);
            _data.SaveChanges();

            return true;
        }

        //all books and the information that we will diplay in all books view
        private static IEnumerable<BookListingVM> GetAllBooksListingModels
            (IQueryable<Book> booksQuery) =>
            booksQuery
                .Select(b => new BookListingVM()
                {
                    Id = b.Id,
                    Title = b.Title,
                    Author = b.AuthorId,
                    ImageUrl = b.ImageUrl,
                    OnlineBookUrl = b.OnlineBookUrl

                })
                .OrderBy(b => b.Title)
                .ToList();

        //add book into db
        private Book FillBookDbModelWithDataAndReturnIt
        (AddBookVM addBookFormModel, string genreId, string authorId, string title, HtmlSanitizer htmlSanitizer)
        {
            var result = new Book()
            {
                Title = title,
                AuthorId = authorId,
                GenreId = genreId,
                Description = htmlSanitizer.Sanitize
                    (addBookFormModel.Description).Trim(),
                ImageUrl = htmlSanitizer.Sanitize(addBookFormModel.ImageUrl).Trim(),
                OnlineBookUrl = htmlSanitizer.Sanitize(addBookFormModel.OnlineBookUrl).Trim()
            };
            return result;
        }

        private EditBookVM GetEditBookFormModel
            (Book book, string genre, string authorId)
        {
            var result = new EditBookVM();
            result.Id = book.Id;
            result.Title = book.Title;
            result.CurrentAuthor = authorId;
            result.Author = book.AuthorId;
            result.CurrentGenre = genre;
            result.GenreId = book.GenreId;
            result.ImageUrl = book.ImageUrl;
               result.OnlineBookUrl = book.OnlineBookUrl;
               result.Description = book.Description;
               result.Genres = GetAllGenresServiceModels();
            return result;
        }
        private void UpdateBookDbModelAndSaveChanges
            (Book book, string genreId,
                EditBookVM editBookFormModel, HtmlSanitizer htmlSanitizer,string authorId)
        {
            book.AuthorId = authorId;
            book.Title = htmlSanitizer.Sanitize(editBookFormModel.Title).Trim();
            book.GenreId = genreId;
            book.Description = htmlSanitizer.Sanitize
                (editBookFormModel.Description).Trim();
            book.ImageUrl = htmlSanitizer.Sanitize(editBookFormModel.ImageUrl).Trim();
            book.OnlineBookUrl = htmlSanitizer.Sanitize(editBookFormModel.OnlineBookUrl).Trim();
            _data.SaveChanges();
        }

        private bool CheckIfGenreExistsInDb(string genreId)
        {
            var genre = GetGenreFromDb(genreId);

            return genre != null;
        }

        private Book GetBookFromDb(string bookId) =>
            _data
                .Books
                .FirstOrDefault(b => b.Id == bookId);

        private Genre GetGenreFromDb(string genreId) =>
            _data
                .Genres
                .FirstOrDefault(g => g.Id == genreId);

        private Author GetAuthorFromDb(string authorId) =>
            _data
                .Authors
                .FirstOrDefault(g => g.Id == authorId);

    }
}
