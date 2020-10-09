using System;
using System.Collections.Generic;

namespace library_db.Models
{
    public partial class Book
    {
        public long BkId { get; set; }
        public long BkName { get; set; }
        public long BkAuthor { get; set; }
        public long BkRealiseDate { get; set; }
        public long PubId { get; set; }
        public long GenId { get; set; }

        public virtual Genre Gen { get; set; }
        public virtual Publisher Pub { get; set; }
    }
}
