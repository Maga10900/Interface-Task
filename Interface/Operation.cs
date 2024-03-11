namespace Interface;

public class Operation
{
    public Guid id { get; set; }
    public string process_name { get; set; }
    public DateTime date_time { get; set; }

    public Operation()
    {
        date_time = DateTime.Now;
        id = Guid.NewGuid();
        process_name = string.Empty;
    }
    public Operation(string name) : this()
    {
        process_name = name;
    }

}
