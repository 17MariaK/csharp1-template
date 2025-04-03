
// METHODS that return sth


internal class Program
{
    private static void Main(string[] args)
    {
        // calling the method, but not saving the returned value
        IamHungryXHours(2);
        // saving the returned value into a variable
        // since the method is bool the variable has to be bool too
        bool IamHungry = IamHungryXHours(2);
        // lets print it
        Console.WriteLine($"I am hungry: {IamHungry}"); // method returns TRUE or FALSE based on the provided parameter
        // with new parameter
        IamHungry = IamHungryXHours(7); // no need to declare the data type
        Console.WriteLine($"I am hungry: {IamHungry}");

        // calling the age method
        int YourAge = CalculateAge(1984);
        // print out the age
        Console.WriteLine($"Your age is {YourAge}");
    }


    // because method has bool -> returns True/False -> can not return return
    // method actually answers a question - are the number of hours that I am hungry > 6 or not? # true/false

    public static bool IamHungryXHours(int NumberHours) // parameter
    {
        if (NumberHours >= 6)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    // lets calculate age
    public static int CalculateAge(int BirthYear)
    {
        int age = 2025 - BirthYear; // takes the year of birth calculates the age and stores it in a variable
        return age;
    }
}

