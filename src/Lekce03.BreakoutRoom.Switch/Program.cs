// Vyber napoja:

// vytvor ciselnu premennu cisloNapoja typu int
int beverageNumber;
// vypis do konzole ponuku napojov:
// 1. Kava
// 2. Caj
// 3. Limonada
// 4. Voda
Console.WriteLine("1. Coffee");
Console.WriteLine("2. Tea");
Console.WriteLine("3. Lemonade");
Console.WriteLine("4. Water");

// Poziadaj uzivatela aby zadal cislo napoja a hodnotu uloz do premennej cislonapoja
Console.WriteLine("Please select a beverage from the menu by entering it's number:");
beverageNumber = int.Parse(Console.ReadLine());

// Pouzi switch:
// pre kazdu z moznosti vypis do konzoly vybrali ste si kavu atd
// pridaj default pre pripad ze napij nie je v menu -> neznamy napoj
switch(beverageNumber)
{
    case 1:
    Console.WriteLine("You choose is Coffee");
    break;
    case 2:
    Console.WriteLine("You choose is Tea");
    break;
    case 3:
    Console.WriteLine("You choose is lemonade");
    break;
    case 4:
    Console.WriteLine("You choose is water");
    break;
    default:
    Console.WriteLine("I did not get your choice.");
    break;
}


// rozsirenie
// pridaj premennu mnozstvo typ int pre mnozstvo napojov
// po vybere napoja poziadaj uzivatela aby zadal mnozstvo
// vypis do konzoly celkovu spravu : vybrali ste si dve kavy



