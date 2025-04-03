/*
Úkol: Kalkulačka v4
Přidejte vaší kalkulačce nový operátor mocnění("^").
Pro operaci mocnění nepoužívejte funkci Math.Pow, ale napište si vlastní logiku.

Stačí k tomu jeden FOR cyklus. Mocnění totiž není nic jiného než opakované násobení.
Například:
2 ^ 4 = 16(dvě na čtvrtou) se dá rozepsat jako 2 * 2 * 2 * 2
3 ^ 3 = 27 se dá rozepsat jako 3 * 3 * 3 apod.

Předpokládejte, že mocnitel je kladné celé číslo (převeďte si druhé vyčtené číslo na int).

Ujistěte se, že mocnění funguje i pro mocnění na 0.
2 ^ 0 = 1 (1)
2 ^ 1 = 2 (1 * 2)
2 ^ 2 = 4 (1 * 2 * 2)
2 ^ 3 = 8 (1 * 2 * 2 * 2)
...
Pokud si nebudete vědět rady jak s mocněním na nultou, neváhejte se zeptat na Discordu svých koučů.
*/


Console.WriteLine("Give me first number: ");
string userInput1 = Console.ReadLine();
double userNumber1;
bool checkedNumber1 = double.TryParse(userInput1, out userNumber1);

// while loop -> in case of incorrect input repeatedly ask for a correct input
while (!checkedNumber1) // condition to be met -> while not a number
{

    Console.WriteLine($"Provided number {userInput1} is not a number. Enter a number:");
    userInput1 = Console.ReadLine();
    checkedNumber1 = double.TryParse(userInput1, out userNumber1);
}

// asking for an operator & using while loop with same logic as with the first number
// adding new operator - square root
Console.WriteLine("Choose one of the operators: +, -, *, /,^");
string userOperator = Console.ReadLine();

while (userOperator != "+" && userOperator !="-" && userOperator !="*" && userOperator != "/" && userOperator != "^")
{
    Console.WriteLine("Invalid operator. Please re-enter correct operator from the provided list.");
    userOperator = Console.ReadLine();
}

// asking for second user's input & using while loop with the same logic as with the first number
// in case of operator is chosen as "^" -> second number is considered to be an exponent
Console.WriteLine("Give me second number: ");
string userInput2 = Console.ReadLine();
double userNumber2; // second number type changed as integer
bool checkedNumber2 = double.TryParse(userInput2, out userNumber2); // double parse change into int.Parse

while (!checkedNumber2)
{
    Console.WriteLine($"Provided number {userInput2} is not a number. Enter a number:");
    userInput2 = Console.ReadLine();
    checkedNumber2 = double.TryParse(userInput2, out userNumber2);
}


// if, else to be simplified with switch the only difference is
// that the variable that stores the result for each of the operation has to be named differently
// for loop for the square root
switch (userOperator)
{
    case "+":
        double resultAdd = userNumber1 + userNumber2;
        Console.WriteLine($"Result: {userNumber1} {userOperator} {userNumber2 }= {resultAdd}");
        break;
    case "-":
        double resultSub = userNumber1 - userNumber2;
        Console.WriteLine($"Result: {userNumber1} {userOperator} {userNumber2 }= {resultSub}");
        break;
    case "*":
        double resultMul = userNumber1 * userNumber2;
        Console.WriteLine($"Result: {userNumber1} {userOperator} {userNumber2 }= {resultMul}");
        break;
    case "/":
        double resultDiv = userNumber1 / userNumber2;
        Console.WriteLine($"Result: {userNumber1} {userOperator} {userNumber2 }= {resultDiv}");
        break;
    case "^":
        // any number raised to power of 0 = 1 -> declared variable with value 1
        // variable declared as double = userNumber1 is a double, and multiplying double values ensures that the result
        // can handle decimal values correctly even if the second user number is declared as integer.
        double resultExp = 1;
        for (int i = 0; i< userNumber2; i++)
        {
            resultExp *= userNumber1;
        }
        Console.WriteLine($"Result: {userNumber1} {userOperator} {userNumber2} = {resultExp}");
        break;
}




