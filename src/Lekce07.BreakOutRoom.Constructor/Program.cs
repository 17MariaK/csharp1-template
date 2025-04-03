//1. Vytvořte třídu Bod, která bude obsahovat souřadnici X a Y.
//    Vytvořte instanci této třídy, naplňte X a Y hodnotami a potom je vytiskněte na konzoli
//2. Ve třídě Bod vytvořte metodu ZobrazInformace,
//    která zobrazí hodnoty např. pro X=1 a Y=2 ve formátu "X: 1, Y: 2"
//3. Vytvořte třídu Usecka, ve které budou dva body A a B.
//4. V programu si vytvořte instanci Usecka, nastavte jí body A a B
//  s libovolnými souřadnicemi (každý bod jiné).
//5. Vytvořte konstruktory pro Bod i Usecku

// Bod osamelyBod = new Bod(4,3)

// Usecka usecka = new Usecka(new Bod(1,2), new Bod(5,3));



internal class Program
{
    // class point with 2 numbers & method
    class Point
    {
        public int X {get; set;}
        public int Y {get; set;}

        // consstructor
        public Point(int x, int y)
        {
            X  = x;
            Y = y;
        }

        // method
        public void ShowInfo()
        {
            Console.WriteLine($"X={X}, Y={Y}.");
        }
    }

    // class usecka
    class Usecka
    {
        public Point A {get; set;}
        public Point B {get; set;}

        // constructor
        public Usecka(Point a, Point b)
        {
            A = a;
            B = b;
        }
    }
    // main
    static void Main()
    {
        Point singlePoint = new Point(4,4); // initialization of a class Point with 2 parameters
        singlePoint.ShowInfo();

        Usecka line = new Usecka(new Point(1,2),new Point(5,3));
        Console.WriteLine("Show the usecka point A: ");
        line.A.ShowInfo();
        Console.WriteLine("Show the usecka point B: ");
        line.B.ShowInfo();

    }

}


