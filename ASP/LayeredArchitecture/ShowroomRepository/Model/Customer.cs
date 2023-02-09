using System;
using System.Collections.Generic;

namespace ShowroomRepository.Model;

public partial class Customer : IEntity
{
    public int Id { get; set; }

    public int? PersonId { get; set; }

    public virtual Person? Person { get; set; }
}
