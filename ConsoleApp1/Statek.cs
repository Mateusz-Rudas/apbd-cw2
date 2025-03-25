namespace ConsoleApp1;

using System;
using System.Collections.Generic;

public class Statek
{
    public double MaksymalnaWaga { get; private set; }
    public int MaksymalnaLiczbaKontenerow { get; private set; }
    public double MaksymalnaPredkosc { get; private set; }
    public List<Kontener> Kontenery { get; private set; }

    public Statek(double maksWaga, int maksKontenery, double maksPredkosc)
    {
        this.MaksymalnaWaga = maksWaga;
        this.MaksymalnaLiczbaKontenerow = maksKontenery;
        this.MaksymalnaPredkosc = maksPredkosc;
        this.Kontenery = new List<Kontener>();
    }

    public void ZaladujKontener(Kontener kontener)
    {
        if (Kontenery.Count >= MaksymalnaLiczbaKontenerow || SumujWage() + kontener.MasaLadunku > MaksymalnaWaga)
            throw new Exception("Statek jest pelny!");

        Kontenery.Add(kontener);
    }
    
    public void UsunKontener(Kontener kontener)
    {
        Kontenery.Remove(kontener);
    }

    public void WypiszInfo()
    {
        Console.WriteLine($"Statek przewozi {Kontenery.Count} kontenerow, laczna waga: {SumujWage()} kg");
        Console.WriteLine($"Maksymalna predkosc: {MaksymalnaPredkosc} wezlow");
        Console.WriteLine($"Maksymalna liczba kontenerow: {MaksymalnaLiczbaKontenerow}");
        Console.WriteLine($"Maksymalna waga ladunku: {MaksymalnaWaga} kg");
        
        foreach (var k in Kontenery)
            Console.WriteLine($"- {k.NumerSeryjny}, masa: {k.MasaLadunku} kg");
    }

    private double SumujWage()
    {
        double suma = 0;
        foreach (var k in Kontenery)
            suma += k.MasaLadunku;
        return suma;
    }  
}