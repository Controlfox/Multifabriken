using System;

namespace Multifabriken;

//Klass som ärver från produkt-klassen
public class Pipe : Products
{
    //Egenskaper för rör
    public double Diameter {get; set;}
    public double Length {get; set;}

    //Konstruktor för rör
    public Pipe(string product,double diameter, double length) : base(product)
    {
        this.Diameter = diameter;
        this.Length = length;
    }
    //Använder metoden för att returnerar produktens egenskaper
    public override string GetInfo()
    {
        return Product + " Diameter " + Diameter + ", längd: " + Length;
    }
}
