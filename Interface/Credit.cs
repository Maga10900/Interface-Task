namespace Interface;

public class Credit
{
    public Guid Id { get; set; }
    Client client { get; set; }
    public int amount { get; set; }
    public int Percent { get; set; }
    public int Months { get; set; }
    public int calculatePercent { get; set; }
    public int payment { get; set; }
    public Credit()
    {
        Id = Guid.NewGuid();
        client = new Client();
        amount = 0;
        Percent = 0;
        Months = 0;
        calculatePercent = 0;
        payment = 0;
    }
    public Credit(Client client, int amount, int Percent, int Months, int ClaculatePercent, int payment) : this()
    {
        Id = Guid.NewGuid();
        this.payment = payment;
        this.amount = amount;
        this.Percent = Percent;
        this.client = client;
        this.calculatePercent = ClaculatePercent;

    }

}

