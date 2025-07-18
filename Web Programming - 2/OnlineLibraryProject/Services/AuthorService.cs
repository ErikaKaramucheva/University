using Ganss.Xss;
using OnlineLibraryProject.Entities;
using OnlineLibraryProject.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibraryProject.Services
{
    public class AuthorService:IAuthorService
    {
        private readonly LibraryDbContext _data;

        public AuthorService(LibraryDbContext data) => _data = data;

        //add genre in db- first check if there is already genre with this name and after add new title in db.
        public bool AddAuthorAndReturnBoolean(string firstName,string lastName)
        {
            var htmlSanitizer = new HtmlSanitizer();
            firstName = htmlSanitizer.Sanitize(firstName).Trim();
            lastName = htmlSanitizer.Sanitize(lastName).Trim();

            if (_data.Authors.Any(a => a.FirstName == firstName &&a.LastName==lastName))
                return false;

            var newAuthor = new Author() { FirstName = firstName, LastName=lastName };
            _data.Authors.Add(newAuthor);
            _data.SaveChanges();

            return true;
        }
    }
}
