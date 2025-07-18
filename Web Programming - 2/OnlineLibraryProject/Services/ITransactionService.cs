using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibraryProject.Services
{
    interface ITransactionService
    {
        public bool CreateTransactionAndReturnBoolean(string userId, string bookId);

    }
}
