namespace ConsoleApp1;

public class KontenerC : Kontener
{
    public double Temperatura { get; private set; }

    public KontenerC(double maksymalnaLadownosc, double temperatura) : base("C", maksymalnaLadownosc)
    {
        this.Temperatura = temperatura;
    }  
}