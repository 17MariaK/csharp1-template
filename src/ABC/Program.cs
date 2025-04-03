
internal class Program
{
    private static void Main(string[] args)
    {
        IntroduceYourself();
        IntroduceYourself(40);
        IntroduceYourself("Maria","Kiacova",40);
    }

    public static void IntroduceYourself()
    {
        Console.WriteLine("My name is Anna Small.");
    }

    public static void IntroduceYourself(int age)
    {
        Console.WriteLine($"My name is Anna Small and I am {age} years old.");
    }

    public static void IntroduceYourself(string name, string surname, int age)
    {
        Console.WriteLine($"My name is {name} {surname} and I am {age} years old.");
    }
}


