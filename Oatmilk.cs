using System;
using System.Data;

namespace Multifabriken;

public class Oatmilk : Products
{
    public double FatProcent {get; set;}
    public double Liter {get; set;}

    public Oatmilk(string product, double fatProcent, double liter) : base(product)
    {
        this.FatProcent = fatProcent;
        this.Liter = liter;
    }

    public override string GetInfo()
    {
        return Product + " Fettprocent: " + FatProcent + ", Liter: " + Liter;
    }
}
