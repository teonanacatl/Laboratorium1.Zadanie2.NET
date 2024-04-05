using System.Text;
namespace Laboratorium1.Zadanie2.NET;

public class Samochod
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public int IloscDrzwi { get; set; }
    public int PojemnoscSilnika { get; set; }
    public double SrednieSpalanie { get; set; }
    private static int _liczbaSamochodow;
    
    private Samochod()
    {
        Marka = "Nieznana";
        Model = "Nieznany";
        IloscDrzwi = 0;
        PojemnoscSilnika = 0;
        SrednieSpalanie = 0.0;
    }
    
    private Samochod(string marka, string model, int iloscDrzwi, int pojemnoscSilnika, double srednieSpalanie)
    {
        Marka = marka;
        Model = model;
        IloscDrzwi = iloscDrzwi;
        PojemnoscSilnika = pojemnoscSilnika;
        SrednieSpalanie = srednieSpalanie;
    }
    
    public static Samochod Stworz()
    {
        _liczbaSamochodow++;
        return new Samochod();
    }

    public static Samochod Stworz(string marka, string model, int iloscDrzwi, int pojemnoscSilnika, double srednieSpalanie)
    {
        _liczbaSamochodow++;
        return new Samochod(marka, model, iloscDrzwi, pojemnoscSilnika, srednieSpalanie);
    }
    
    private double ObliczSpalanie(double dlugoscTrasy)
    {
        double spalanie = (SrednieSpalanie * dlugoscTrasy) / 100.0;
        return spalanie;
    }

    public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
    {
        double spalanie = ObliczSpalanie(dlugoscTrasy);
        double kosztPrzejazdu = spalanie * cenaPaliwa;
        return kosztPrzejazdu;
    }
    
    public void WypiszInfo()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"Marka: {Marka}");
        stringBuilder.AppendLine($"Model: {Model}");
        stringBuilder.AppendLine($"Ilość drzwi: {IloscDrzwi}");
        stringBuilder.AppendLine($"Pojemność silnika: {PojemnoscSilnika}");
        stringBuilder.AppendLine($"Średnie spalanie: {SrednieSpalanie}");
        Console.WriteLine(stringBuilder.ToString());
    }
    
    public static void WypiszLiczbeSamochodow()
    {
        Console.WriteLine($"Liczba samochodów: {_liczbaSamochodow}");
    }
}
