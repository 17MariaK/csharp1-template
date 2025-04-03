// Kalkulačka v2
// Kalkulačka nám už počítá. Teď se ale musíme postarat o to, že uživatel může zadat špatné číslo.
// Kalkulačku upravíme tak, aby se ukončila, pokud uživatel zadá špatný vstup.
// Každou situaci budeme ověřovat právě jednou. Pokud se něco zadá špatně, kalkulačka skončí.
// Kalkulačku můžeme kdykoliv ukončit pomocí příkazu "return;"

// Požádejte uživatele o zadání prvního čísla.
// NOVINKA: Musíme double.Parse zaměnit za double.TryParse a přidat bool proměnnou,
// kterou si dokážeme ověřit převod vstupu tak, jako jsme to dělali na lekci.
// NOVINKA: Pokud je první číslo nesprávně zadané, napište uživateli zprávu a program ukončete pomocí příkazu return;

// User input for the first number & check if number is number
Console.WriteLine("Give me first number: "); // Asking for user's input
// user provides input [it can be whatever e.g. 1, 5, abc etc]
string userInput1 = Console.ReadLine();
// used as second parameter into TryParse() method where the checked value is stored
// if string provided it will return 0.0 or 0 when variable is printed out
double userNumber1;
// returns True/False based on the evaluation of the provided user's input
// first parameter userInput1 and its value is checked and if number it will be stored within second parameter userNumber1
// variable checkednumber1 stores TRUE / FALSE based on the evaluation
bool checkedNumber1 = double.TryParse(userInput1, out userNumber1);

// check whether the user's input is a number -> FALSE: Provided number 0 is not a number.
if (!checkedNumber1)
{
    Console.WriteLine($"Provided number {userNumber1} is not a number.");
    return;
}

// Požádejte uživatele o zadání operátoru.
// NOVINKA: Platnost operátoru zjistíte pomocí ifu složeného ze 4 podmínek v parametru
// (musíte ověřit pomocí „nebo“ všechny možné operátory).
// NOVINKA: Pokud je operátor nesprávně zadaný, napište uživateli zprávu a program ukončete pomocí příkazu return;

Console.WriteLine("Choose one of the operators: +, -, *, /");
string userOperator = Console.ReadLine();

if(userOperator != "+" && userOperator !="-" && userOperator !="*" && userOperator != "/")
{
    Console.WriteLine("Invalid operator. Please re-enter correct operator from the provided list.");
    return;
}

// Požádejte uživatele o zadání druhého čísla.
// NOVINKA: Musíme double.Parse zaměnit za double.TryParse a přidat bool proměnnou,
// kterou si dokážeme ověřit převod vstupu tak, jako jsme to dělali na lekci.
// NOVINKA: Pokud je druhé číslo nesprávně zadané, napište uživateli zprávu a program ukončete pomocí příkazu return;

Console.WriteLine("Give me second number: ");
string userInput2 = Console.ReadLine();
double userNumber2;
bool checkedNumber2 = double.TryParse(userInput2, out userNumber2);

if (!checkedNumber2)
{
    Console.WriteLine($"Provided number {userNumber2} is not a number.");
    return;
}


// Vypočítejte výsledek a vypište ho do konzole.

//Program by měl při správném zadávání do konzole vypisovat následovně:
// Zadej první číslo:
// 10
// Zadej operátor (+, -, *, /):
// *
// Zadej druhé číslo:
// 7
// Výsledek: 10 * 7 = 70

// if, else to be simplified with switch the only difference is
// that the variable that stores the result for each of the operation has to be named differently
switch (userOperator)
{
    case "+":
        double resultAdd = userNumber1 + userNumber2;
        Console.WriteLine("Result: " + userNumber1 + userOperator + userNumber2 + "=" + resultAdd);
        break;
    case "-":
        double resultSub = userNumber1 - userNumber2;
        Console.WriteLine("Result: " + userNumber1 + userOperator + userNumber2 + "=" + resultSub);
        break;
    case "*":
        double resultMul = userNumber1 * userNumber2;
        Console.WriteLine("Result: " + userNumber1 + userOperator + userNumber2 + "=" + resultMul);
        break;
    case "/":
        double resultDiv = userNumber1 / userNumber2;
        Console.WriteLine("Result: " + userNumber1 + userOperator + userNumber2 + "=" + resultDiv);
        break;
}
