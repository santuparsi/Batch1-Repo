using System;
using System.Collections.Generic;

namespace HandsOnEFDBFirst.Entities
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public string Did { get; set; } = null!;
        public string Dname { get; set; } = null!;

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
