using System;
using System.Collections.Generic;

namespace ShowroomRepository.Model;

public partial class Car : IEntity
{
    public int Id { get; set; }

    public string Make { get; set; } = null!;

    public string Model { get; set; } = null!;

    public int? Year { get; set; }

    public string? ImageUrl { get; set; }

    public virtual ICollection<Sale> Sales { get; } = new List<Sale>();

    public override string ToString()
    {
        return
            $"Make: {Make}\n" +
            $"Model: {Model}\n" +
            $"Year: {Year}\n" +
            $"ImageUrl{ImageUrl}\n";
    }
}
