using OnlineLibraryProject.Entities;
using OnlineLibraryProject.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibraryProject.Services
{
    public class TransactionService:ITransactionService
    {
        private readonly LibraryDbContext _data;
        public TransactionService(LibraryDbContext data) => _data = data;

        //add book to myLibrary
        public bool CreateTransactionAndReturnBoolean(string userId, string bookId)
        {
            var book = GetBookFromDb(bookId);

            if (book == null)
                return false;

            var newTransaction = new Transaction() { BookId = bookId, UserId = userId };
            _data.Transactions.Add(newTransaction);
            _data.SaveChanges();
            return true;
        }


        private Book GetBookFromDb(string bookId) =>
          _data
              .Books
              .FirstOrDefault(b => b.Id == bookId);


    }
}
