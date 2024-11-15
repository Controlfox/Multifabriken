using System;
using System.Dynamic;

namespace Multifabriken;
//Skapar basklass för alla produkter
public abstract class Products
{

    //Lagrar produkten
    public string Product{get; set;}

    //Konstruktor för produkttyp
    public Products(string product)
    {
        this.Product = product;
    }

    //Metod för att returnera information om produkten
    public abstract string GetInfo();

    //Metod för tack-meddelande
    public void SayThanks()
    {
        Console.WriteLine("Tack för din beställning! Din " + Product + " finns nu i varukorgen.");
    }

}
