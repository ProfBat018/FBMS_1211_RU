﻿namespace Serializing;

public class Animal
{
    public string? Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}" + "\n" +
               $"Age: {Age}" + "\n";
    }
}