using System;

namespace Multifabriken;
//Klass som ärver från produkt-klassen
public class Candy : Products
{
    //Egenskaper för godiset
    public string Flavour {get; set;}
    public double Amount {get; set;}

    //Konstruktor för godis
    public Candy(string product,string flavour, double amount) : base(product)
    {
        this.Flavour = flavour;
        this.Amount = amount;
    }

    //Använder metoden för att returnerar produktens egenskaper
    public override string GetInfo()
    {
        return Product + " Smak: " + Flavour + ", antal: " + Amount;
    }
}
