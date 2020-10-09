using System;
using System.Collections.Generic;

namespace library_db.Models
{
    public partial class Reader
    {
        public long RdId { get; set; }
        public long RdFullName { get; set; }
        public long RdBdDate { get; set; }
        public long RdSex { get; set; }
        public long RdAddress { get; set; }
        public long RdPhoneNumber { get; set; }
        public long RdPassportData { get; set; }
    }
}
