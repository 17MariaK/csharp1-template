
/*
1) Vytvořte metodu PredstavSe(), která vypíše do konzole jméno a příjmení.
Jméno a příjmení si libovolně zvol a zadefinuj je přímo v tělu metody.
2) Zavolej tuto metodu v Main. Zkontroluj, že v konzoli je očekávaný výstup.
3) Vytvořte metodu PredstavSe(int vek), která vypíše do konzole jméno, příjmení a věk
(jeho hodnotu získáš v metodě pomocí parametru "vek").
Jméno a příjmení si libovolně zvol a zadefinuj je přímo v tělu metody.
4) Zavolej tuto metodu v Main. Vyzkoušej si, že v konzoli se vypisuje věk, který metodě předáš pomocí parametru "vek".

Bonus: 5) Vytvoř metodu PredstavSe, která bude příjímat parametry: jmeno, prijmeni, vek
Tato metoda pak vypíše do konzole například:
"Jmenuji se Pavel Novák, je mi 36 let."
6) Zavolej tuto metodu zde v Main.
       */


internal class Program
{
    private static void Main(string[] args)
    {
        IntroduceYourself();
        IntroduceYourself(40);
        IntroduceYourself("Maria","Kiacova",40);
    }
    public static void IntroduceYourself() //VOID means that method will not return anything, just displays what is within the Console
    {
        Console.WriteLine("My name is Anna Small.");
    }

    public static void IntroduceYourself(int age)
    {
        Console.WriteLine($"My name is Anna Small and I am {age} years old.");
    }

    public static void IntroduceYourself(string name, string surname, int age)
    {
        Console.WriteLine($"My name is {name} {surname} and I am {age} years old.");
    }
}


