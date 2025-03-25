namespace ConsoleApp1;

using System;

public class KontenerG : Kontener, IHazardNotifier
{
    public double Cisnienie { get; private set; }

    public KontenerG(double maksymalnaLadownosc, double cisnienie) : base("G", maksymalnaLadownosc)
    {
        this.Cisnienie = cisnienie;
    }

    public override void Oproznij()
    {
        MasaLadunku *= 0.05; // Zostawiamy 5% ladunku
    }

    public void NotifyHazard(string message)
    {
        Console.WriteLine($"[ALERT] {NumerSeryjny}: {message}");
    } 
}