//  FOR loop

for (int i =0; i<3; i++)
{
    Console.WriteLine(i);
}


// ODD, EVEN number
// using for loop

int firstNumber = 0;
int lastNumber = 30;

for (int i = firstNumber; i < lastNumber; i+=1)
{
    bool oddNumber = i % 2 !=0;
    bool evenNumber = i % 2 ==0;
    if (oddNumber)
    {
        Console.WriteLine($"Number {i} is odd.");
    }

}
