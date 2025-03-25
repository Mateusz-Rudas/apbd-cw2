// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1;

class Program
{
    static void Main()
    {
        Statek statek1 = new Statek(50000, 10, 25.0);
        Statek statek2 = new Statek(60000, 15, 30.0);

        KontenerC kontenerC = new KontenerC(1000, -18);
        KontenerG kontenerG = new KontenerG(500, 2.5);
        KontenerL kontenerL = new KontenerL(800, true);

        kontenerC.Zaladuj(500);
        kontenerG.Zaladuj(300);
        kontenerL.Zaladuj(400);

        statek1.ZaladujKontener(kontenerC);
        statek1.ZaladujKontener(kontenerG);
        statek1.ZaladujKontener(kontenerL);

        Console.WriteLine("Po zaladowaniu kontenerow:");
        statek1.WypiszInfo();

        statek1.UsunKontener(kontenerG);
        Console.WriteLine("Po usunieciu kontenera gazowego:");
        statek1.WypiszInfo();

        kontenerC.Oproznij();
        Console.WriteLine("Po oproznieniu kontenera chlodniczego:");
        statek1.WypiszInfo();

        statek1.ZaladujKontener(new KontenerC(1200, -10));
        Console.WriteLine("Po zastapieniu kontenera nowym:");
        statek1.WypiszInfo();

        statek1.UsunKontener(kontenerL);
        statek2.ZaladujKontener(kontenerL);
        Console.WriteLine("Po przeniesieniu kontenera miedzy statkami:");
        Console.WriteLine("Statek 1:");
        statek1.WypiszInfo();
        Console.WriteLine("Statek 2:");
        statek2.WypiszInfo();
    }
}
