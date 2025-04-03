// Zadání je tedy následující:
// 1. Vytvoř si nový konzolový projekt - budeme začínat na zelené louce
// 2. Zadefinuj třídu Kalkulacka
// 3. Třída Kalkulacka si musí umět pamatovat aktuální výsledek (vlastnost třídy Kalkulacka) -
// aktuální výsledek by měl být po vytvoření kalkulačky nulový a měl by být desetinného typu.
// 4.  Zadefinuj a naimplementuj metodu JePlatnyOperator, která nám bude vracet True právě tehdy,
// když vstupní parametr této metody bude jeden z námi podporovaných operací (‘+’,’-’,’*’,’/’,’^’).
// 5. Zadefinuj a naimplementuj metody třídy (Pricti, Odecti, …) pro všechny podporované operace.
//Metody budou pracovat s jedním vstupním parametrem a upravovat aktuální výsledek kalkulačky.
// 6. Zadefinuj a naimplementuj metodu VratAktualniVysledek, která nám bude vracet aktuální výsledek kalkulačky.
// 7. Zkontroluj si, že Kalkulacka nevolá Console (ani ReadLine, ani WriteLine).
// 8. Ověř si, že logika tvé kalkulačky funguje správně pomocí jejího provolávání v Main
// (první číslo nastavíme kalkulačce pomocí metody Pricti) Viz níže v příkladu, který můžeš doplnit svým kódem.

internal class Program
{
    public class Calculator
    {
        // to define attribute latest result
        public double latestResult;

        // defining the value for attribute -> should be 0 and floating point number
        public Calculator()
        {
            latestResult = 0.0;
        }

        // method return valid operator  -> True
        public bool ValidOperator(char oper)
        {
            return oper == '+' || oper == '-' || oper == '*' || oper == '/' || oper == '^';
        }

        // calculation method +, -, /, *, ^
        public void Addition(double number)
        {
            latestResult += number;
        }
        public void Substraction(double number)
        {
            latestResult -= number;
        }
        public void Multiplication(double number)
        {
            latestResult *= number;
        }
        public void Division(double number)
        {
            latestResult /= number;
        }

        public double ReturnLatestResult()
        {
            return latestResult;
        }

    }

    private static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        calculator.Addition(10);
        Console.WriteLine("Addition: " + calculator.ReturnLatestResult());

        calculator.Substraction(3);
        Console.WriteLine("Substraction: " + calculator.ReturnLatestResult());

        calculator.Multiplication(2);
        Console.WriteLine("Multiplication: " + calculator.ReturnLatestResult());

        calculator.Division(2);
        Console.WriteLine("Divisio: " + calculator.ReturnLatestResult());
    }
}
