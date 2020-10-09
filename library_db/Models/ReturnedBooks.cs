using System;
using System.Collections.Generic;

namespace library_db.Models
{
    public partial class ReturnedBooks
    {
        public long RbReturnDate { get; set; }
        public long RbGiveOutDate { get; set; }
        public long RbReturnFlag { get; set; }
        public long EmpId { get; set; }
        public long RdId { get; set; }
        public long BkId { get; set; }

        public virtual Book Bk { get; set; }
        public virtual Employee Emp { get; set; }
        public virtual Reader Rd { get; set; }
    }
}
