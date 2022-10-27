using System;
using System.Collections.Generic;

namespace HandsOnEFDBFirst.Entities
{
    public partial class ViewEmpIt
    {
        public int Eid { get; set; }
        public string Ename { get; set; } = null!;
        public decimal? Salary { get; set; }
        public string? Did { get; set; }
    }
}
