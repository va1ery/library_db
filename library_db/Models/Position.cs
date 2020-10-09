using System;
using System.Collections.Generic;

namespace library_db.Models
{
    public partial class Position
    {
        public Position()
        {
            Employee = new HashSet<Employee>();
        }

        public long PosId { get; set; }
        public long PosName { get; set; }
        public long PosSalary { get; set; }
        public long PosDuties { get; set; }
        public long PosRequirements { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
