using System;

namespace Multifabriken;
//Klass som ärver från produkt-klassen
public class Car : Products
{
    //Egenskaper för bilen
    public string RegNr {get; set;}
    public string Colour {get; set;}
    public string Brand {get; set;}

    //Konstruktor för bilen
    public Car(string product, string regNr, string colour, string brand) : base(product)
    {
        this.RegNr = regNr;
        this.Colour = colour;
        this.Brand = brand;
    }


    //Använder metoden för att returnerar produktens egenskaper
    public override string GetInfo()
    {
        return Product + " regnr: " + RegNr + ", färg: " + Colour + ", märke: " + Brand;
    }
}
