class Person
{
    public Person(string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    public sealed override string ToString()
    {
        return $"{Name}\n{Surname}\n{Age}\n";
    }
}

class Student : Person
{
    public Student(string name, string surname, int age) : base(name, surname, age)
    {

    }

}

