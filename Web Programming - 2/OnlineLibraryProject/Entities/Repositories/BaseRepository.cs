using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibraryProject.Entities.Repositories
{
    public abstract class BaseRepository<T>
        where T:BaseEntity
    {
        protected LibraryDbContext _context;
        protected DbSet<T> DbSet { get; set; }

        public BaseRepository()
        {

        }
    }
}
