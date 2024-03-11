using System;

namespace Interface;

public class CEO : Person, IStep
{
    public CEO() : base()
    {

    }
    public CEO(string name, string surname, int age, string position, int salary) : base(name, surname, age, position, salary) { }
    public void Organize() { Console.WriteLine("good"); }
    public void Control() { Console.WriteLine("bad"); }
    public void MakeMeeting() { Console.WriteLine("MakeMeeting"); }
    public void DecreasePercentage() { Console.WriteLine("DecreasePercentage"); }


}