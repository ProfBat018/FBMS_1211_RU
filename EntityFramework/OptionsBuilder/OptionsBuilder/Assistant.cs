using System;
using System.Collections.Generic;

namespace OptionsBuilder
{
    public partial class Assistant
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; } = null!;
    }
}
