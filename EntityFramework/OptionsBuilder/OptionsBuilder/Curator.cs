using System;
using System.Collections.Generic;

namespace OptionsBuilder
{
    public partial class Curator
    {
        public Curator()
        {
            GroupsCurators = new HashSet<GroupsCurator>();
        }

        public int Id { get; set; }
        public int TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; } = null!;
        public virtual ICollection<GroupsCurator> GroupsCurators { get; set; }
    }
}
