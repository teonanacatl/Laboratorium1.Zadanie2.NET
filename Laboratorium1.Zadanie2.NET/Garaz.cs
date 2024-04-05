namespace Laboratorium1.Zadanie2.NET

{
    public class Garaz
    {
        public string Adres { get; set; }
        
        private int _pojemnosc;
        private int _liczbaSamochodow;
        private Samochod?[] _samochody = Array.Empty<Samochod?>();
        
        public int Pojemnosc
        {
            get { return _pojemnosc; }
            set
            {
                _pojemnosc = value;
                _samochody = new Samochod[_pojemnosc];
            }
        }

        public Garaz()
        {
            Adres = "Nieznany";
            Pojemnosc = 0;
        }

        public Garaz(string adres, int pojemnosc)
        {
            Adres = adres;
            Pojemnosc = pojemnosc;
        }

        public void WprowadzSamochod(Samochod samochod)
        {
            if (_liczbaSamochodow == _pojemnosc)
            {
                Console.WriteLine("Garaż jest pełny. Nie można wprowadzić więcej samochodów.");
            }
            else
            {
                _samochody[_liczbaSamochodow] = samochod;
                _liczbaSamochodow++;
            }
        }

        public Samochod? WyprowadzSamochod()
        {
            if (_liczbaSamochodow == 0)
            {
                Console.WriteLine("Garaż jest pusty. Nie ma żadnych samochodów do wyprowadzenia.");
                return null;
            }
            else
            {
                Samochod? samochodDoWyprowadzenia = _samochody[_liczbaSamochodow - 1];
                _samochody[_liczbaSamochodow - 1] = null;
                _liczbaSamochodow--;
                return samochodDoWyprowadzenia;
            }
        }

        public void WypiszInfo()
        {
            Console.WriteLine($"Adres: {Adres}");
            Console.WriteLine($"Pojemność: {_pojemnosc}");
            Console.WriteLine($"Liczba samochodów: {_liczbaSamochodow}");

            for (int i = 0; i < _liczbaSamochodow; i++)
            {
                Console.WriteLine($"Samochód {i + 1}:");
                _samochody[i]?.WypiszInfo();
            }
        }
    }
}