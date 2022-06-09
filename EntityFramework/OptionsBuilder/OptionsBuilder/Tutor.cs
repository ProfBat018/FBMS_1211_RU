using System;
using System.Collections.Generic;

namespace OptionsBuilder
{
    public partial class Tutor
    {
        public int Id { get; set; }
        public int? StaffId { get; set; }

        public virtual staff? Staff { get; set; }
    }
}
