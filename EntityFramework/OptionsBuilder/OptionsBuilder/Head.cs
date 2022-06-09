using System;
using System.Collections.Generic;

namespace OptionsBuilder
{
    public partial class Head
    {
        public Head()
        {
            Departments = new HashSet<Department>();
        }

        public int Id { get; set; }
        public int TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; } = null!;
        public virtual ICollection<Department> Departments { get; set; }
    }
}
