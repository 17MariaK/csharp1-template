// use while loop
// ask user for year when he/she was born
// check if it's an integer ->  use TryParse
// calculate user's age based on the provided year

// user's input
Console.WriteLine("Give me your year of birth");
// save user's input
string userInput = Console.ReadLine();

// control check
int userAge; // variable where the user's input will be assigned
bool controlAge = int.TryParse(userInput, out userAge);

while (!controlAge)
{
    Console.WriteLine($"Your provided input {userAge} is incorrect. Provide year: ");
    userInput = Console.ReadLine();
    controlAge = int.TryParse(userInput, out userAge);
}

int currentYear = 2025 - userAge;
Console.WriteLine($"You are {currentYear} years old.");
