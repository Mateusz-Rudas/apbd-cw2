namespace ConsoleApp1;

using System;

public class KontenerL : Kontener, IHazardNotifier
{
    public bool NiebezpiecznyLadunek { get; private set; }

    public KontenerL(double maksymalnaLadownosc, bool niebezpieczny) : base("L", maksymalnaLadownosc)
    {
        this.NiebezpiecznyLadunek = niebezpieczny;
    }

    public override void Zaladuj(double masa)
    {
        double limit = NiebezpiecznyLadunek ? MaksymalnaLadownosc * 0.5 : MaksymalnaLadownosc * 0.9;
        if (MasaLadunku + masa > limit)
            NotifyHazard("Proba przepelnienia kontenera plynow!");
        else
            MasaLadunku += masa;
    }

    public void NotifyHazard(string message)
    {
        Console.WriteLine($"[UWAGA] {NumerSeryjny}: {message}");
    } 
}