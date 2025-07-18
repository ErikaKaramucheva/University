using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibraryProject.Entities
{
    public static class GlobalConstants
    {
        public const string UrlRegex = @"(https?:\/\/(?:www\.|(?!www))[a-zA-Z0-9][a-zA-Z0-9-]+[a-zA-Z0-9]\.[^\s]{2,}|www\.[a-zA-Z0-9][a-zA-Z0-9-]+[a-zA-Z0-9]\.[^\s]{2,}|https?:\/\/(?:www\.|(?!www))[a-zA-Z0-9]+\.[^\s]{2,}|www\.[a-zA-Z0-9]+\.[^\s]{2,})
";
    }

    public static class Notifications
    {
        public const string SuccessfullyAddedBookKey =
            "SABK";
        public const string SuccessfullyAddedTransactionKey =
           "SATK";

        public const string SuccessfullyAddedBook = "Книгата беше добавена успешно!";
        public const string SuccessfullyAddedTransaction = "Книгата беше добавена успешно към библиотеката!";

        public const string SuccessfullyEditedBookKey =
            "SEBK";

        public const string SuccessfullyEditedBook = "Книгата беше редактирана успешно!";

        public const string SuccessfullyDeletedBookKey =
            "SDBK";

        public const string SuccessfullyDeletedBook = "Книгата беше премахната успешно!";

        public const string UnsuccessfullyDeletedBookKey =
            "UDBK";
        public const string UnsuccessfullyAddTransactionKey =
            "UDBK";

        public const string UnsuccessfullyDeletedBook = "Книгата не беше премахната!";
        public const string UnsuccessfullyAddedTransaction = "Книгата не беше добавена към библиотеката!";

        public const string SuccessfullyAddedGenreKey =
            "SDBK";

        public const string SuccessfullyAddedGenre = "Жанрът беше добавен успешно!";
        public const string SuccessfullyAddedAuthorKey =
            "SDАK";

        public const string SuccessfullyAddedAuthor = "Авторът беше добавен успешно!";
    }

    public static class ErrorMessages
    {
        public const string SomethingWentWrong = "Упс... нещо се обърка!";

        public const string NoBooksFound = "За съжаление не беше открита книга!";

        public const string BookNotFound = "Книгата не беше открита!";

        public const string TitleAlreadyExists = "Книга с това заглавие вече съществува!";

        public const string GenreDoesNotExists = "Жанрът не съществува!";

        public const string GenreNameAlreadyExists = "Жанрът, който искате да добавите вече съществува!";
        public const string AuthorNameAlreadyExists = "Авторът, който искате да добавите вече съществува!";
    }
    public static class Paging
    {
        public const int CurrentPageStart = 1;

        public const int FourCardsPerPage = 4;
    }


}
