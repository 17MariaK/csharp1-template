using System;

public class Kalkulacka
{
    private double aktualniVysledek = 0;

    public double VratAktualniVysledek()
    {
        return aktualniVysledek;
    }

    public bool JePlatnyOperator(string oper)
    {
        return oper == "+" || oper == "-" || oper == "*" || oper == "/" || oper == "^";
    }

    public void Pricti(double cislo)
    {
        aktualniVysledek += cislo;
    }

    public void Odecti(double cislo)
    {
        aktualniVysledek -= cislo;
    }

    public void Vynasob(double cislo)
    {
        aktualniVysledek *= cislo;
    }

    public void Vydel(double cislo)
    {
        if (cislo != 0)
        {
            aktualniVysledek /= cislo;
        }
        else
        {
            Console.WriteLine("Chyba: Nelze dělit nulou.");
        }
    }

    public void Umocni(int exponent)
    {
        double vysledek = 1;
        for (int i = 0; i < Math.Abs(exponent); i++)
        {
            vysledek *= aktualniVysledek;
        }
        if (exponent < 0)
        {
            vysledek = 1 / vysledek;
        }
        aktualniVysledek = vysledek;
    }
}


internal class Program
{
    static void Main()
    {
        Kalkulacka kalkulacka = new Kalkulacka();

        while (true)
        {
            Console.WriteLine($"Aktuální výsledek: {kalkulacka.VratAktualniVysledek()}");

            double cislo = NactiDesetinneCisloZKonzole();
            string oper = NactiOperatorZKonzole(kalkulacka);

            switch (oper)
            {
                case "+":
                    kalkulacka.Pricti(cislo);
                    break;
                case "-":
                    kalkulacka.Odecti(cislo);
                    break;
                case "*":
                    kalkulacka.Vynasob(cislo);
                    break;
                case "/":
                    kalkulacka.Vydel(cislo);
                    break;
                case "^":
                    kalkulacka.Umocni((int)cislo);
                    break;
            }

            Console.WriteLine("Chcete pokračovat? (ano/ne)");
            if (Console.ReadLine().Trim().ToLower() != "ano")
                break;
        }
    }

    static double NactiDesetinneCisloZKonzole()
    {
        double cislo;
        while (true)
        {
            Console.Write("Zadejte číslo: ");
            if (double.TryParse(Console.ReadLine(), out cislo))
                return cislo;
            Console.WriteLine("Neplatný vstup. Zadejte prosím platné číslo.");
        }
    }

    static string NactiOperatorZKonzole(Kalkulacka kalkulacka)
    {
        while (true)
        {
            Console.Write("Zadejte operátor (+, -, *, /, ^): ");
            string oper = Console.ReadLine().Trim();
            if (kalkulacka.JePlatnyOperator(oper))
                return oper;
            Console.WriteLine("Neplatný operátor. Zadejte prosím platný operátor.");
        }
    }
}
