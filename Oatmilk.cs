using System;
using System.Data;

namespace Multifabriken;
//Klass som ärver från produkt-klassen
public class Oatmilk : Products
{
    //Egenskaper för havremjölk
    public double FatProcent {get; set;}
    public double Liter {get; set;}

    //Konstruktor för havremjölk
    public Oatmilk(string product, double fatProcent, double liter) : base(product)
    {
        this.FatProcent = fatProcent;
        this.Liter = liter;
    }
    //Använder metoden för att returnerar produktens egenskaper
    public override string GetInfo()
    {
        return Product + " Fettprocent: " + FatProcent + ", Liter: " + Liter;
    }
}
