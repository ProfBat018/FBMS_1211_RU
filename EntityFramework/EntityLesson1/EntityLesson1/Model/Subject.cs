using System;
using System.Collections.Generic;

namespace EntityLesson1.Model
{
    public partial class Subject
    {
        public Subject()
        {
            Lectures = new HashSet<Lecture>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Lecture> Lectures { get; set; }
    }
}
