
internal class Program
{
    private class Auto
    {
        public string Vyrobce;
        public int PocetSedadel;
        public int RokVyroby;
        public string Barva;
        public bool MaSpecialniDisky;

        public string PopisSe()
        {
            return $"Na sklade mam {Vyrobce}, pocet sedadel {PocetSedadel}, rok vyroby {RokVyroby} a barvy {Barva}. Mam specialni disky : {MaSpecialniDisky}.";
        }
    }

// Object Initializer the defined attibutes of the class are within curly brackets {} and that we do not have to write it as
// class.atrribute but only attribute
    static void Main(string[] args)
    {
        Auto ferrari = new Auto
        {
            Barva = "Cervena",
            MaSpecialniDisky = true,
            PocetSedadel = 2,
            RokVyroby = 2012,
            Vyrobce = "Ferrari",
        };

        string popisFerrari = ferrari.PopisSe();
        Console.WriteLine(popisFerrari);

        Auto skoda = new Auto();
        skoda.Vyrobce = "Skoda";
        skoda.PocetSedadel = 4;
        skoda.RokVyroby = 2015;
        skoda.Barva = "Cerna";
        skoda.PocetSedadel = 5;

        Console.WriteLine(skoda.PopisSe());
    }
}



