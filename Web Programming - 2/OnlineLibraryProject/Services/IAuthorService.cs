using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibraryProject.Services
{
    public interface IAuthorService
    {
        bool AddAuthorAndReturnBoolean(string firstName, string lastName);
    }
}
