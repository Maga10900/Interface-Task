using System.Runtime.ConstrainedExecution;

namespace Interface;

public class Bank
{
    public string name { get; set; }
    public int Budget { get; set; }
    public string profit { get; set; }
    List<CEO> CEOs { get; set; }
    List<Worker> workers { get; set; }
    List<Manager> Manegers { get; set; }
    List<Client> Clients { get; set; }

    public void CalculateProfit()
    {
        Console.WriteLine("CalculateProfit");
    }
    public void ShowClientCredit(string fullname)
    {
        foreach (var c in Clients)
        {
            if (c.Name == fullname)
                Console.WriteLine(c.ToString());
        }
    }
    public void PayCredit(int MOney)
    {
        Console.WriteLine("Money");
    }
    public void ShowAllCredits()
    {
        Console.WriteLine("Showallcredirs");
    }
}

