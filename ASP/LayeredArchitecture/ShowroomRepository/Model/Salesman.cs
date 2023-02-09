using System;
using System.Collections.Generic;

namespace ShowroomRepository.Model;

public partial class Salesman : IEntity
{
    public int Id { get; set; }

    public int? PersonId { get; set; }

    public int? SalesCount { get; set; }

    public virtual Person? Person { get; set; }

    public virtual ICollection<Sale> Sales { get; } = new List<Sale>();
}
