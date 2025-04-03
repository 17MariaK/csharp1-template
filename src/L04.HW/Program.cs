
// Úkol: Kalkulačka v3
// Kalkulačka už nám umí zkontrolovat jestli je vstup špatný, ale pouze jednou a potom skončí.

// ● NOVINKA: DOKUD je nesprávný vstup (neplatné číslo nebo operátor), opakovaně se ptejte uživatele dokud nezadá správný vstup.
// Použijte správný typ cyklu.
// ● NOVINKA: Výpočet s operátorem proveďte z IF-ELSEIF-ELSE na SWITCH.
// ● NOVINKA: Až kalkulačka vrátí výsledek, neukončujte program, ale spusťte jej celý program znova
// (celý program bude v nekonečném cyklu/smyčce).

// Asking for user's input
// variable to store the checked input from True / False
// variable True/False used to check the user's input
Console.WriteLine("Give me first number: ");
string userInput1 = Console.ReadLine();
double userNumber1;
bool checkedNumber1 = double.TryParse(userInput1, out userNumber1);

// while loop -> in case of incorrect input repeatedly ask for a correct input
while (!checkedNumber1) // condition to be met -> while not a number
{
    // re-promt the user to provide correct input - number
    Console.WriteLine($"Provided number {userInput1} is not a number. Enter a number:");
    userInput1 = Console.ReadLine();
    // checkedNumber1 variable updated -> new input is revalidated determine whether to exit the loop
    // & it is without bool as data type because declaring a variable happens only ONCE -> it did already happen at the beginning
    // after this, only the value within it is updated -> no need to declare it again
    checkedNumber1 = double.TryParse(userInput1, out userNumber1);
}

// asking for an operator & using while loop with same logic as with the first number
Console.WriteLine("Choose one of the operators: +, -, *, /");
string userOperator = Console.ReadLine();

while (userOperator != "+" && userOperator !="-" && userOperator !="*" && userOperator != "/")
{
    Console.WriteLine("Invalid operator. Please re-enter correct operator from the provided list.");
    userOperator = Console.ReadLine();
}

// asking for second user's input & using while loop with the same logic as with the first number
Console.WriteLine("Give me second number: ");
string userInput2 = Console.ReadLine();
double userNumber2;
bool checkedNumber2 = double.TryParse(userInput2, out userNumber2);

while (!checkedNumber2)
{
    Console.WriteLine($"Provided number {userInput2} is not a number. Enter a number:");
    userInput2 = Console.ReadLine();
    checkedNumber2 = double.TryParse(userInput2, out userNumber2);
}


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

