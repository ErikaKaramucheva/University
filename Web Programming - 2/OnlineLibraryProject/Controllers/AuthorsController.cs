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
    public class AuthorsController : Controller
    {
        private readonly LibraryDbContext _context;
        private readonly IAuthorService _authorsService;


        public AuthorsController(LibraryDbContext context,IAuthorService authorService)
        {
            _context = context;
            _authorsService = authorService;
        }

        // GET: Authors
        public async Task<IActionResult> Index()
        {
            return View(await _context.Authors.ToListAsync());
        }

        public IActionResult AddAuthor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAuthor(AddAuthorVM addAuthor)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(String.Empty, SomethingWentWrong);
                return RedirectToAction(nameof(this.AddAuthor));
            }
            //boolean- if false- author exists, else - it is successfully added
            var isAuthorAdded = _authorsService.AddAuthorAndReturnBoolean(addAuthor.FirstName,addAuthor.LastName);

            if (!isAuthorAdded)
            {
                ModelState.AddModelError(String.Empty, AuthorNameAlreadyExists);
                return RedirectToAction(nameof(this.AddAuthor));
            }

            TempData[SuccessfullyAddedAuthorKey] = SuccessfullyAddedAuthor;

            return RedirectToAction(nameof(this.AddAuthor));
        }
    }
}
