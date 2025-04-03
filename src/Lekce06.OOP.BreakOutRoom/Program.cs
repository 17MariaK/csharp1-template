
// Úkol: Třída Clovek
// --------------------------------------------
// Vytvořte třídu Clovek, která bude obsahovat následující vlastnosti:
//   - jméno (string)
//   - pohlaví (string)
//   - rok narození (int)
//   - hmotnost (double)
//   - v manželství (bool)
//
// Dále proveďte následující kroky:
//   1. Vytvořte dvě instance třídy Clovek a naplňte je daty.
//   2. Vypište informace o těchto instancích na konzoli .
//      (zatím pouze pomocí Console.WriteLine v metodě Main)

internal class Program
{
    // CLASS
    class Human
    {
        public string Name;
        public string Gender;
        public int YearBirth;
        public double weight;
        public bool married;
    }


    private static void Main(string[] args)
    {
        Human marek = new Human();
        marek.Name = "Marek";
        marek.Gender = "Male";
        marek.YearBirth = 1984;
        marek.weight = 79.0;
        marek.married = true;

        Console.WriteLine($"{marek.Name},{marek.Gender},{marek.YearBirth},{marek.weight},{marek.married}");


        Human eva = new Human();
        eva.Name = "Eva";
        eva.Gender = "Female";
        eva.YearBirth = 1984;
        eva.weight = 59.0;
        eva.married = true;

        Console.WriteLine($"{eva.Name},{eva.Gender},{eva.YearBirth},{eva.weight},{eva.married}");

    }
}
