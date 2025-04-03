// vytvorit triedu- rytier
// vlastnosti triedy - meno, pocet, zivotov, sila
// metoda UtocNaDraka ->  vypise na konzolu: "Utocim na draka"
// metoda predstav sa -> vypise informacie o rytierovi

// CONSTRUCTOR
internal class Program
{
    public class Knight
    {
        // CONSTRUCTOR
        public Knight(string name, int numberOfLife, int power)
        {
            Name = name;
            NumberOfLife = numberOfLife;
            Power = power;
        }

        public string Name;
        public int NumberOfLife;
        public int Power;

        //metoda predstav sa
        public void IntroduceYourself()
        {
            Console.WriteLine($"My name is knight {Name},I have {NumberOfLife} life and my power is {Power}.");
        }
    }

    private static void Main(string[] args)
    {
        Knight knight = new Knight("Adam", 1, 5);
        knight.IntroduceYourself();

        knight.Name = "Bonifac";
        knight.NumberOfLife = 5;
        knight.Power = 3;

        knight.IntroduceYourself();


        // pouzitie CONSTRUCTORA
        Knight ferdinand = new Knight
        (
            "Ferdinand",
            4,
            8
        );
    }
}
