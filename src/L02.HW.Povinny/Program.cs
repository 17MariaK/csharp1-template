/*
Úkol: Kalkulačka v1
Je tu druhý povinný domácí úkol! Už jste se naučili spoustu věcí, abyste mohli napsat první pořádný program.
Možná vás překvapuje, proč v.1?
Při programování se programy často rozšiřují podle požadavků zákazníka.
I vy budete kalkulačku neustále vylepšovat, takže první verze bude docela základní kalkulačka a postupně do ní doplníte spoustu dalších věcí (které se naučíte).
Takže pusťte se do toho, odevzdat můžete do komentáře v MojeCzechitas jako link na DotNetFiddle (https://dotnetfiddle.net) do příští lekce!

● Požádejte uživatele o zadání prvního čísla (ukládejte jako double, ať můžeme dělit a nezapomeňte,
že v kódu se používáme desetinnou tečku) a pomocí double.Parse převeďte vstup na číselnou hodnotu

// Pokud jsme na lekci stihli pouze int.Parse, není se čeho bát, double.Parse funguje obdobným způsobem:
string desetinneCisloJakoText = Console.ReadLine();
double desetinneCislo = double.Parse(desetinneCisloJakoText)

● Poté požádejte uživatele o zadání operátoru pro matematickou operaci sčítání (+), odčítání (-), násobení (*) nebo dělení (/).
Uživatel napíše jedno ze čtyř znamének a vy jej uložíte do string proměnné.
● Požádejte uživatele o zadání druhého čísla, uložte jako double.
● V tuto chvíli tedy máte dvě čísla a operátor. Vytvořte vícenásobný IF-ELSEIF-ELSE, podle obsahu proměnné
s operátorem (4 případy) vypočítejte výsledek operace, ten uložte do předpřipravené proměnné.
● Nakonec vypište celou operaci a k tomu výsledek.

Takto by to mohlo vypadat v konzoli po dokončení úkolu:
    Zadej první číslo:
    10
    Zadej operátor (+, -, *, /):
    *
    Zadej druhé číslo:
    7
    Výsledek: 10 * 7 = 70

Ať se daří. Rozhodně se neváhejte ozvat na Discordu, moc rádi vám pomůžeme, když si nebudete vědět rady.
*/

// User input for the first number
Console.WriteLine("Give me first number: ");
string userNumber1 = Console.ReadLine();
double numberFirst = double.Parse(userNumber1);

// to choose : + / - / * /
Console.WriteLine("Choose one of the operators: +, -, *, /");
string userOperator = Console.ReadLine();

// User input for the second number
Console.WriteLine("Give me second number: ");
string userNumber2 = Console.ReadLine();
double numberSecond = double.Parse(userNumber2);

// if, else if, else
if (userOperator == "+")
{
    double result = numberFirst + numberSecond;
    Console.WriteLine("Result:" + numberFirst + userOperator + numberSecond+ "=" + result);
}
else if (userOperator == "-")
{
    double result = numberFirst - numberSecond;
    Console.WriteLine("Result:" + numberFirst + userOperator + numberSecond+ "=" + result);
}
else if (userOperator == "*")
{
    double result = numberFirst * numberSecond;
    Console.WriteLine("Result:" + numberFirst + userOperator + numberSecond+ "=" + result);
}
else if (userOperator == "/")
{
    double result = numberFirst / numberSecond;
    Console.WriteLine("Result:" + numberFirst + userOperator + numberSecond+ "=" + result);
}
