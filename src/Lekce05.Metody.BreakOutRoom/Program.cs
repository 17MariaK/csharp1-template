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

internal class NewBaseType
{
    private static void Main(string[] args)
    {
}

internal class Program : NewBaseType
{
    public static void IntroduceYourself()
        {
            Console.WriteLine("My name is Jozko Mrkvicka.");
        }
    }
}
