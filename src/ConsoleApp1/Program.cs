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
        public Knight(string name, int numberOfLife)
        {
            Name = name;
            NumberOfLife = numberOfLife;
        }

        // 2nd CONSTRUCTOR -> has to have different number of parameters and other attributes will be defined
        public Knight(string name)
        {
            Name = name;
            NumberOfLife = 5;
        }

        private string Name;
        private int NumberOfLife;

        //metoda predstav sa
        public void IntroduceYourself()
        {
            Console.WriteLine($"My name is knight {Name},I have {NumberOfLife}.");
        }

        // metoda utocim na draka -> vstupny parameter moze byt aj samotna trieda
        public void AttackingDragon(Dragon dragon)
        {
            Console.WriteLine($"I am attacking dragon {dragon.GetDragonName("wouldyoukindly")}.");
        }
    }

    // vytvor triedu Drak -> meno, pocet zivotov, silu
    // metodu predstav sa -> vypise informacie o drakovi
    // metoda zasiahnuty rytierom -> znizi drakovi pocet zivotov o jeden a vypise "Kde mam hlavu"

    public class Dragon
    {
        // constructor
        public Dragon(string name, int numberOfHead)
        {
            Name = name;
            // constructor je dobry ak overeniu vstupu -> drak by mal mat aspon jednu hlavu a to mi osetri ten IF/ELSE
            if(numberOfHead < 1) // ak je pocet hlav 0 alebo -1
            {
                NumberOfHead = 1; // pocet hlav sa nastavi na 1
            }
            else
            {
                NumberOfHead = numberOfHead; // v opacnom pripade nastav pocet hlav ako zadal uzivatel
            }
        }

        // chcem pristupit k menu draka -> nezmenim Name atribut na public ale osetrim si ho nasledovne:
        // constructor ziskaj meno
        public string GetDragonName(string password)
        {
            if(password == "wouldyoukindly")
            {
                return Name;
            }
            return "Unknown";
        }

        private string Name;
        private int NumberOfHead;

        // metoda predstav sa
        public void IntroduceYourself()
        {
            Console.WriteLine($"I am a dragon and my name is {Name}, I have number of heads {NumberOfHead}.");
        }

        /* Metoda zasiahnuty rytierom, která drakovi sníží počet hlav o 1 a vypíše, "Kde mám hlavu!"
         a pokud už jsou všechny hlavy pryč, napíše "Jsem poražen ..."*/
         public void HitByKnight()
         {
            if(NumberOfHead>0)
            {
                Console.WriteLine("Where is my head?");
                NumberOfHead --; // znizuje ten pocet hlav aby sa dostal do else vetvy
            }
            else
            {
                Console.WriteLine("I am hit...");
            }
         }
    }

    private static void Main(string[] args)
    {
        // CONSTRUCTOR - only
        Knight konstantin = new Knight("Konstantin", 10);
        konstantin.IntroduceYourself();

        //vytvorenie instancie Drak
        Dragon vendelin = new Dragon("Vendelin", 0);
        vendelin.IntroduceYourself();

        konstantin.AttackingDragon(vendelin);
        vendelin.HitByKnight();
        vendelin.HitByKnight();
    }
}
