// Metody
// execute 3x in a row "Hello World"

internal class Program
{
    private static void Main(string[] args) // this one does not return anything, just executes whatever is within it - void
    {
        Console.WriteLine("Hello World!");

        HelloWorld();
        HelloWorld();
        HelloWorld();
    }

    // Metod without parameters and return value

    public static void HelloWorld()
    {
        Console.WriteLine("Hello World!");
    }
}
