using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibraryProject.Entities
{
    public abstract class BaseEntity
    {
        public BaseEntity() => Id = Guid.NewGuid().ToString();

        public string Id { get; set; }
    }
}
