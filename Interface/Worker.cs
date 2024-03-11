namespace Interface;

public class Worker : Person
{
    DateTime StartTime { get; set; }
    TimeSpan EndTime { get; set; }
    List<string> Opearations { get; set; }
    public void AddOperations()
    {
        Console.WriteLine("Added");
    }

    public Worker() : base()
    {
        Opearations = new List<string>();
        StartTime = DateTime.Now;
        Thread.Sleep(1000);
        EndTime = StartTime - DateTime.Now;
    }
    public Worker(string name, string surname, int age, string position, int salary, List<string> opeartions) : base(name, surname, age, position, salary)
    {
        Opearations = new List<string>();
        StartTime = DateTime.Now;
        Thread.Sleep(1000);
        EndTime = StartTime - DateTime.Now;
    }
}
