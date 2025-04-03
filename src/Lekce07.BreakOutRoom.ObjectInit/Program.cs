// Breakout Room 1 - Rozsirime tridu Clovek z minule lekce
// napiste metodu VypisInformace, ktera vypise vsechny vlastnosti
// v metode VypisInformace napiste "zenaty" nebo "vdana" (nikoliv true nebo false) podle hodnoty vlastnosti "pohlavi"
// Vytvor metodu VratVek, ktera podle roku narozeni vypocita a vrati aktualni vek. Ten vypis na konzoli.
// Pro definici noveho objektu pouzij object initializer

using System.Security.Cryptography.X509Certificates;

internal class Program
{
    // CLASS
    class Human
    {
        public string Name;
        public string Gender;
        public int YearBirth;
        public double Weight;
        public bool married; // true / false

        // method that returns characteristics
        // based on the gender and married true/false -> zenaty, vydata
        public void DescribeYourself()
        {
            if (Gender == "Male" && married == true)
            {
                string GenderMan = "zenaty";
                Console.WriteLine($"Provided information: {Name},{Gender},{YearBirth},{Weight},{GenderMan}");
            }
            else if (Gender == "Female" && married == true)
            {
                string GenderWoman = "vydata";
                Console.WriteLine($"Provided information: {Name},{Gender},{YearBirth},{Weight},{GenderWoman}");
            }
            else
            {
                string GenderSingle = "single";
                Console.WriteLine($"Provided information: {Name},{Gender},{YearBirth},{Weight},{GenderSingle}");
            }

        }
        public void AgeReturn()
        {
            int currentYear = DateTime.Now.Year; // very basic just you assing the current year
            int age = currentYear - YearBirth;
            Console.WriteLine($"Age of {Name}: {age}");
        }
    }
    private static void Main(string[] args)
    {
        Human marek = new Human();
        marek.Name = "Marek";
        marek.Gender = "Male";
        marek.YearBirth = 1984;
        marek.Weight = 79.0;
        marek.married = false;

        marek.DescribeYourself();
        marek.AgeReturn();


        Human eva = new Human();
        eva.Name = "Eva";
        eva.Gender = "Female";
        eva.YearBirth = 1984;
        eva.Weight = 59.0;
        eva.married = true;

        eva.DescribeYourself();
        eva.AgeReturn();

    }
}
