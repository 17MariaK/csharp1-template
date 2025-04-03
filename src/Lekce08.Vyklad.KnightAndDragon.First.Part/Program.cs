// vytvorit triedu- rytier
// vlastnosti triedy - meno, pocet, zivotov, sila
// metoda UtocNaDraka ->  vypise na konzolu: "Utocim na draka"
// metoda predstav sa -> vypise informacie o rytierovi

internal class Program
{
    public class Knight
    {
        public string Name;
        public int NumberOfLife;
        public int Power;

        // metoda Predstav sa
        public void IntroduceYourself()
        {
            Console.WriteLine($"My name is knight {Name},I have {NumberOfLife} lifes and my power is {Power}.");
        }
    }

    private static void Main(string[] args)
    {
        Knight knight = new Knight(); // vytvorenie obbjektu triedy Knight ktoru si pomenujem ako knight
        knight.Name = "Bonifac"; // pripisanie konkretnych vlastnosti tejto danej triedy
        knight.NumberOfLife = 5;
        knight.Power = 3;
        // spustenie metody
        knight.IntroduceYourself();
    }
}
