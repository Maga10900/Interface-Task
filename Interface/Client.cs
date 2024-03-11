namespace Interface;

public class Client : Person
{
    public string live_address { get; set; }
    public string work_address { get; set; }
    public Client() : base()
    {
        live_address = string.Empty;
        work_address = string.Empty;
    }
    public Client(string name, string surname, int age, string position, int salary, string liveAddress, string WorkAddress) : base(name, surname, age, position, salary)
    {
        live_address = liveAddress;
        work_address = WorkAddress;
    }

}
