// / 1.Vypiš uživateli text s žádostí o zadání jeho křestního jména (Console.WriteLine()).
Console.WriteLine("Give me your name: ");

// 2.Vytvoř proměnnou datového typu string, do které přiřadíš vstup uživatele (Console.ReadLine()).
// Uživatel zadá v konzoli své křestní jméno.

string userName = Console.ReadLine();

// 3.Vypiš uživateli text s žádostí o zadání jeho příjmení (Console.WriteLine()).

Console.WriteLine("Give me your surname: ");

// 4.Vytvoř proměnnou datového typu string, do které přiřadíš vstup uživatele  (Console.ReadLine()).
// Uživatel zadá v konzoli své příjmení.

string userSurname = Console.ReadLine();

// 5.Vytvoř proměnnou datového typu string obsahující celé jméno. Přiřaď do ní spojení již zadaného křestního jména a příjmení
//   (spoj je mezerou, tak abychom dostali celé jméno ve formátu: “Karel Novák”)

string userWholeName = userName+ ' ' +userSurname;

// 6.Vypiš uživateli jeho celé jméno zpátky do konzole ve tvaru
//   “Vaše křestní jméno je Karel, vaše příjmení je Novák, celým jménem Karel Novák.”

Console.WriteLine($"Your name is {userName}, your surname is {userSurname}, your full name is {userWholeName}");
