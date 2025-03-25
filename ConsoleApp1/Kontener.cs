namespace ConsoleApp1;

using System;

public class Kontener
{
    private static int counter = 1;
    public string NumerSeryjny { get; private set; }
    public double MasaLadunku { get; protected set; }
    public double MaksymalnaLadownosc { get; protected set; }
    
    public Kontener(string typ, double maksymalnaLadownosc)
    {
        this.NumerSeryjny = $"KON-{typ}-{counter++}";
        this.MaksymalnaLadownosc = maksymalnaLadownosc;
        this.MasaLadunku = 0;
    }

    public virtual void Zaladuj(double masa)
    {
        if (MasaLadunku + masa > MaksymalnaLadownosc)
            throw new Exception("OverfillException: Przekroczono pojemnosc kontenera!");
        
        MasaLadunku += masa;
    }

    public virtual void Oproznij()
    {
        MasaLadunku = 0;
    } 
}