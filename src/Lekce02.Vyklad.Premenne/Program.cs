// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Lesson 2- about variables and data types!");

// VARIABLES

int number = 5; // deklarovala / vytvorila som a inicializovala som premennu & priradila som jej hodnotu

// deklarovat premennu mozem aj bez toho aby som je priradila nejaku hodnotu -> int x;
// uz zadeklarovanu premennu mozem aj prepisovat - teda jej hodnotu viem prepisovat ale neviem menit jej datovy typ
number = 10;

//vypis premennej do konzoly
Console.WriteLine(number); //Console.Writeline je to iste ako print() v Pythone
Console.WriteLine("Menim hodnotu premennej");
number = 13;
Console.WriteLine(number);

// celociselne delenie
int number_2 = 5/3;
Console.WriteLine(number_2);

//desatinne cisla
double float_number = 1.4;
Console.WriteLine(float_number);
double addition_number = float_number + 0.4;
Console.WriteLine(addition_number);

//string
string text1 = "Hello";
string text2 = "Maria";
string t1t2 = text1+' ' + text2;
Console.WriteLine(t1t2);

// user input -> I want sth from the user [in Python input()]
// it is always a STRING
Console.WriteLine("Give me your name:");
string userInput = Console.ReadLine();
Console.WriteLine("Your name is: " + userInput);



