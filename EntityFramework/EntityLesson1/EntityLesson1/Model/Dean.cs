using System;
using System.Collections.Generic;

namespace EntityLesson1.Model
{
    public partial class Dean
    {
        public Dean()
        {
            Faculties = new HashSet<Faculty>();
        }

        public int Id { get; set; }
        public int TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; } = null!;
        public virtual ICollection<Faculty> Faculties { get; set; }
    }
}
