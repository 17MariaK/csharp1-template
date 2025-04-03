
// define class
class Calculator
{
    double latestResult; // declaring variable for saving the latest result -> whatever it is

    // constructor for setting the latest result to floating number
    Calculator()
    {
        latestResult = 0.0;
    }

    // method for checking the correctness of the operator
    public bool ValidOperator(char useroperator)
    {
        return useroperator == '+' || useroperator == '-' || useroperator == '*' || useroperator == '/' || useroperator == '^';
    }
    // addition
    public void Addition(double value)
    {
        latestResult += value;
    }
    // substraction
    public void Substraction(double value)
    {
        latestResult -= value;
    }
    // multiplication
    public void Multiplication(double value)
    {
        latestResult *= value;
    }
    // division -> control flow to avoid division by 0
    public void Division(double value)
    {
        if (value != 0)
        {
            latestResult /= value;
        }
        else
        {
            return; // for now leave it like this
        }
    }
    // return of the actual result
    public double AktualnyVysledok()
}

class Program
{
    private static void Main(string[] args)
    {
        // creating new instance of the class
        Calculator calculator = new Calculator();

        calculator.Addition(10);


    }
}

