using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FluentApi
{
    public partial class Assistant
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; } = null!;
    }
}
