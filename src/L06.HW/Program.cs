/*
Další vylepšení vaší kalkulačky! 🤯
umožněte uživateli střídavě zadávat čísla a operátory, dokud ho to neomrzí
(zadá například X, přičemž ho akceptujte jenom při zadávání operátoru).

BONUS: pokud si troufnete tak i během zadávání čísla
pokud zjistíte, že uživatel požádal o ukončení programu, bude se vám zde hodit klíčové slůvko return,
které stojí na řádku samostatně, následuje pouze středník return;.
po každé operaci ukažte výsledek
Takto by to mohlo vypadat v konzoli po dokončení příkladu:
Zadej číslo:
10
Zadej operátor (+, -, *, /, ^) nebo X pro ukonceni:
+
Zadej číslo:
7
Výsledek: 10 + 7 = 17
Zadej operátor (+, -, *, /, ^) nebo X pro ukonceni:
-
Zadej číslo:
15
Výsledek: 17 - 15 = 2
Zadej operátor (+, -, *, /, ^) nebo X pro ukonceni:
^
Zadej číslo:
5
Výsledek: 2 ^ 5 = 32
Zadej operátor (+, -, *, /, ^) nebo X pro ukonceni:
X
Kalkulačka končí.
*/

// FIRST NUMBER user input
// adjustment: double.TryParse is within the while loop that checks if number is provide
Console.WriteLine("Give me first number: ");
string userInput1 = Console.ReadLine();
double userNumber1;

// while loop -> repeatedly asks for a correct input if incorrect one has been provided
while (!double.TryParse(userInput1, out userNumber1))
{
    Console.WriteLine($"Provided number {userInput1} is not a number. Enter a number:");
    userInput1 = Console.ReadLine();
}

// one while loop that secures user to re-enter the numbers/operators or end the program
while (true)
{
    // asks for operator or X
    Console.WriteLine("Choose one of the operators: +, -, *, /,^, or press X if you want to end the program.");
    string userOperator = Console.ReadLine();

    // if X is pressed -> program ends nothing else is executed
    if (userOperator == "X")
    {
        Console.WriteLine("Program ends.");
        return;
    }
    // if operator is provided correct / incorrect -> program continues
    if (userOperator != "+" && userOperator != "-" && userOperator != "*" && userOperator != "/" && userOperator != "^")
    {
        Console.WriteLine("Invalid operator. Please re-enter correct operator from the provided list, or press X if you wish to end the program.");
        continue;
    }

    // SECOND NUMBER user input -> double.TryParse adjustment
    Console.WriteLine("Give me a second number: ");
    string userInput2 = Console.ReadLine();
    double userNumber2;

    // check if number provided
    while (!double.TryParse(userInput2, out userNumber2))
    {
        Console.WriteLine($"Provided number {userInput2} is not a number. Enter a number: ");
        userInput2 = Console.ReadLine();
    }

    // calculation based on the provided input
    // declare variable to be used for repeated calculation
    double repeatNumber = userNumber1;
    switch (userOperator)
    {
        case "+":
            userNumber1 += userNumber2;
            break;
        case "-":
            userNumber1 -= userNumber2;
            break;
        case "*":
            userNumber1 *= userNumber2;
            break;
        case "/":
            userNumber1 /= userNumber2;
            break;
        case "^":
            double resultExp = 1;
            for (int i = 0; i < userNumber2; i++)
            {
                resultExp *= userNumber1; // executes the calculation -> body of the for loop
            }
            userNumber1 = resultExp; // since there is one printout at the end, the result of the for loop has to be assigned to the usernumber1
            break;
    }
    Console.WriteLine($"Result is: {repeatNumber} {userOperator} {userNumber2} = {userNumber1}");
}







