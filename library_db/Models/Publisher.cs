using System;
using System.Collections.Generic;

namespace library_db.Models
{
    public partial class Publisher
    {
        public Publisher()
        {
            Book = new HashSet<Book>();
        }

        public long PubId { get; set; }
        public long PubName { get; set; }
        public long PubCity { get; set; }
        public long PubAddress { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}
