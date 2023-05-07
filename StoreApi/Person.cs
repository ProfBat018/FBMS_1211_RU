using System;
using System.Collections.Generic;

namespace StoreApi
{
    public partial class Person
    {
        public Person()
        {
            BonusCards = new HashSet<BonusCard>();
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public int Age { get; set; }

        public virtual ICollection<BonusCard> BonusCards { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
