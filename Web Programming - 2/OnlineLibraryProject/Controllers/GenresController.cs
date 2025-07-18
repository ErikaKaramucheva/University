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
    public class GenresController : Controller
    {
        private readonly LibraryDbContext _context;
        private readonly IGenresService _genresService;

        public GenresController(LibraryDbContext context,IGenresService genresService )
        {
            _context = context;
            _genresService = genresService;
        }

        // GET: Genres
        public async Task<IActionResult> Index()
        {
            return View(await _context.Genres.ToListAsync());
        }


        // GET: Genres/Create
        public IActionResult AddGenre()
        {
            return View();
        }

        // POST: Genres/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddGenre(AddGenreVM addGenre)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(String.Empty, SomethingWentWrong);
                return RedirectToAction(nameof(this.AddGenre));
            }
            //boolean- if false- genre exists, else - it is successfully added
            var isGenreAdded = _genresService.AddGenreAndReturnBoolean(addGenre.Name);

            if (!isGenreAdded)
            {
                ModelState.AddModelError(String.Empty, GenreNameAlreadyExists);
                return RedirectToAction(nameof(this.AddGenre));
            }

            TempData[SuccessfullyAddedGenreKey] = SuccessfullyAddedGenre;

            return RedirectToAction(nameof(this.AddGenre));
        
    }


        private bool GenreExists(string id)
        {
            return _context.Genres.Any(e => e.Id == id);
        }
    }
}
