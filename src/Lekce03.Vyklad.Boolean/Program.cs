// vstupne premenne
bool isWeatherGood = true;
bool isWeekend = false;

bool doSports = isWeatherGood && isWeekend; // I want to do sports when it is a weekend and weather is good

if (doSports)
{
    Console.WriteLine("I want to do sposrts- it is weekend and weather is good.");
}
else
{
    Console.WriteLine("I am going to do sports a different time the conditions are not good.");
}

// else is going to be executed
// if the weekend would be true the first one would be executed

// effective -> executed when true
if (doSports) {}
if (doSports==true){}

// effective -> executed when false
if (doSports) {}
if (doSports==false){}
