using Ganss.Xss;
using OnlineLibraryProject.Entities;
using OnlineLibraryProject.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibraryProject.Services
{
    public class GenresService:IGenresService
    {
        private readonly LibraryDbContext _data;

        public GenresService(LibraryDbContext data) => _data = data;

        //add genre in db- first check if there is already genre with this name and after add new title in db.
        public bool AddGenreAndReturnBoolean(string name)
        {
            var htmlSanitizer = new HtmlSanitizer();
            name = htmlSanitizer.Sanitize(name).Trim();

            if (_data.Genres.Any(g => g.Name == name))
                return false;

            var newGenre = new Genre() { Name = name };
            _data.Genres.Add(newGenre);
            _data.SaveChanges();

            return true;
        }
    }
}
