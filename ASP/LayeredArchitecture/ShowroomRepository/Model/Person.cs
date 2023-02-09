using System;
using System.Collections.Generic;

namespace ShowroomRepository.Model;

public partial class Person : IEntity
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public int? Age { get; set; }

    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();

    public virtual ICollection<Sale> Sales { get; } = new List<Sale>();

    public virtual ICollection<Salesman> Salesmen { get; } = new List<Salesman>();
}
