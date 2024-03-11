namespace Interface;

public class Manager : Person, IStep
{
    public Manager() : base()
    {

    }
    public Manager(string name, string surname, int age, string position, int salary) : base(name, surname, age, position, salary) { }
    public void Organize()
    {
        Console.WriteLine("organize");
    }
    public void CalculateSalary()
    {
        Console.WriteLine("CalculateTaxes");
    }
}
