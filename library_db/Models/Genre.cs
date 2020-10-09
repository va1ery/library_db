using System;
using System.Collections.Generic;

namespace library_db.Models
{
    public partial class Genre
    {
        public Genre()
        {
            Book = new HashSet<Book>();
        }

        public long GenId { get; set; }
        public long GenName { get; set; }
        public long GenDescription { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}
