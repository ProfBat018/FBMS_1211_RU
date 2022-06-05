using System;
using System.Collections.Generic;

namespace EntityLesson1.Model
{
    public partial class staff
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public int? Age { get; set; }
        public string Email { get; set; } = null!;

        public virtual Tutor? Tutor { get; set; }
    }
}
