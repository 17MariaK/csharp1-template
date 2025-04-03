
// CLASS

internal class Program
{
    class Car // class defined with attributes
    {
        public string Manufacturer;
        public int NumberSeats;
        public int Year;
        public string Color;

        // method of the class
        public void DescribeYourself()
        {
            Console.WriteLine($"We do have a car {Manufacturer}, with number of seats {NumberSeats} and color {Color}.");

        }
    }

    private static void Main(string[] args)
    {

        Car mercedes = new Car(); // NEW instance of Class Car & stored in variable "mercedes"
        // these are the attributes
        mercedes.Manufacturer = "Mercedes";
        mercedes.NumberSeats = 2;
        mercedes.Year = 2025;
        mercedes.Color = "Black";

        mercedes.DescribeYourself();


        Car volvo = new Car(); // new instance of Class Car & stored in variable "mercedes"
        // these are the attributes
        volvo.Manufacturer = "Volvo";
        volvo.NumberSeats = 4;
        volvo.Year = 2024;
        volvo.Color = "Red";

        volvo.DescribeYourself();

    }
}
