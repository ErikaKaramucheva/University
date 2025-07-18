using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineLibraryProject.Entities;
using OnlineLibraryProject.Entities.Repositories;
using OnlineLibraryProject.Services;
using OnlineLibraryProject.ViewModels;
using static OnlineLibraryProject.Entities.ErrorMessages;
using static OnlineLibraryProject.Entities.Notifications;

namespace OnlineLibraryProject.Controllers
{
    public class TransactionsController : Controller
    {
        private readonly LibraryDbContext _context;

        private readonly TransactionService _transactionService;

        public TransactionsController(LibraryDbContext context)
        {
            _context = context;
        }


        //Get
        public IActionResult Create()
        {
            //transmit book to VM
            var addTransactionFormModel = new AddTransactionVM()
            { Books = GetAllBooks() };

            if (addTransactionFormModel.Books?.Count() < 1)
                ModelState.AddModelError(String.Empty, SomethingWentWrong);

            return View(addTransactionFormModel);
        }
        //get all book from db
        public List<BookServiceVM> GetAllBooks()
             => _context
           .Books
           .Select(b => new BookServiceVM()
           {
               Id = b.Id,
               Title = b.Title
           })
           .ToList();

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Creates(AddTransactionVM addTransaction)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(String.Empty, SomethingWentWrong);
                return View("Create", addTransaction);
            }
            //get info-id for logged user, and the book that he want to borrow and add this info in db
            var userId = addTransaction.UserId;
            var bookId = addTransaction.BookId;
            var transaction =
                _transactionService
                .CreateTransactionAndReturnBoolean(userId, bookId);

            if (ModelState.ErrorCount > 0)
            {
                addTransaction.BookId = bookId;
                return View("Create", addTransaction);
            }

            TempData[SuccessfullyAddedTransactionKey] = SuccessfullyAddedTransaction;

            return RedirectToAction(nameof(BooksController.MyLibrary));
        }




        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var transaction = await _context.Transactions.FindAsync(id);
            _context.Transactions.Remove(transaction);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(BooksController.MyLibrary));
        }


        private bool TransactionExists(string id)
        {
            return _context.Transactions.Any(e => e.Id == id);
        }
    }
}
