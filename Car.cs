using System;

namespace Multifabriken;

public class Car : Products
{
    public string RegNr {get; set;}
    public string Colour {get; set;}
    public string Brand {get; set;}
    public Car(string product, string regNr, string colour, string brand) : base(product)
    {
        this.RegNr = regNr;
        this.Colour = colour;
        this.Brand = brand;
    }



    public override string GetInfo()
    {
        return Product + " regnr: " + RegNr + ", färg: " + Colour + ", märke: " + Brand;
    }
}
