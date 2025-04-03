// vytvorit triedu- rytier
// vlastnosti triedy - meno, pocet, zivotov, sila
// metoda UtocNaDraka ->  vypise na konzolu: "Utocim na draka"
// metoda predstav sa -> vypise informacie o rytierovi

// OBJECT INITIALIZER
internal class Program
{
    public class Knight
    {
        public string Name;
        public int NumberOfLife;
        public int Power;
    }

    private static void Main(string[] args)
    {
        Knight knight = new Knight();
        knight.Name = "Bonifac";
        knight.NumberOfLife = 5;
        knight.Power = 3;

        // OBJECT INITIALIZER
        Knight ferdinand = new Knight
        {
            Name = "Ferdinand",
            NumberOfLife = 4,
            Power = 8,

        };
    }
}
