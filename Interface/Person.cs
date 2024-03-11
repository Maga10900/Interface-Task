namespace Interface;

public abstract class Person
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int age { get; set; }
    public string Position { get; set; }
    public int salary { get; set; }

    public Person()
    {
        Name = string.Empty;
        Surname = string.Empty;
        Position = string.Empty;
        age = 0;
        salary = 0;
        Id = Guid.NewGuid();

    }
    public Person(string name, string surname, int age, string position, int salary) : this()
    {
        Name = name;
        Surname = surname;
        this.age = age;
        Position = position;
        this.salary = salary;
    }

}

