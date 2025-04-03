// SWITCH
// chcem osetrit program ktory riesi vlakovy poriadok

string destinationStation = "Praha";

switch(destinationStation)
{
    case "Praha":
    Console.WriteLine("We are going to Praha.");
    break;

    case "Brno":
    Console.WriteLine("We are going to Brno.");
    break;

    default:
    Console.WriteLine("I do not know this destination");
    break;
}

// viem chain viac CASE pod seba napr.:
// case "Praha Hlavna stanica":
// case "Praha Holesovice":
// case "Praha Masarykovo nadrazi":
// a tym viac menej sa zbavim vela else if podmienok v kode. 
