using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLesson1.Model
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
