using System;

namespace Multifabriken;

public class Candy : Products
{
    public string Flavour {get; set;}
    public double Amount {get; set;}

    public Candy(string product,string flavour, double amount) : base(product)
    {
        this.Flavour = flavour;
        this.Amount = amount;
    }

    public override string GetInfo()
    {
        return Product + " Smak: " + Flavour + ", antal: " + Amount;
    }
}
