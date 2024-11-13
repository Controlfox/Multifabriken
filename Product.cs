using System;
using System.Dynamic;

namespace Multifabriken;

public abstract class Products
{

    public string Product{get; set;}

    public Products(string product)
    {
        this.Product = product;
    }

    
    public abstract string GetInfo();

    public void SayThanks()
    {
        System.Console.WriteLine("Tack för din beställning! Din " + Product + " finns nu i varukorgen.");
    }
}
