//1. Pomocí cyklu vypiš 3x nějakou stejnou zprávu, např.:
/*
    Pomocí cyklu vypiš 3x nějakou stejnou zprávu, např.:
    Ahoj
    Ahoj
    Ahoj
*/
for (int i =0; i<3; i++)
{
    Console.WriteLine("Hello World!");
}

/*
    2. Pomocí cyklu vypiš čísla 5 až 1 sestupně.
*/
for (int number = 5; number>0; number -=1)
{
    Console.WriteLine(number);
}

/*
    3. Napiš program, který si bude myslet náhodné číslo od 0 do 10 a uživatel bude moci až 3x hádat. Pokud uhodne,
    program skončí dříve a vypíše, že číslo uhodl správně. Pro generování náhodného čísla lze použít

    Random generator = new Random();
    int nahodneCislo = generator.Next(11);
    např:
    Myslím si číslo, hádej 3x!
    5
    Kdepak, znovu:
    8
    Kdepak, znovu:
    3
    Kdepak!
*/

Random generator = new Random();
int randomNumber = generator.Next(11);

