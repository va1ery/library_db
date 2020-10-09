using System;
using System.Collections.Generic;

namespace library_db.Models
{
    public partial class Employee
    {
        public long EmpId { get; set; }
        public long EmpFullName { get; set; }
        public long EmpAge { get; set; }
        public long EmpSex { get; set; }
        public long EmpAddress { get; set; }
        public long EmpPhoneNumber { get; set; }
        public long EmpPassportData { get; set; }
        public long PosId { get; set; }

        public virtual Position Pos { get; set; }
    }
}
