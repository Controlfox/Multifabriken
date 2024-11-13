using System;

namespace Multifabriken;

public class Pipe : Products
{
    public double Diameter {get; set;}
    public double Length {get; set;}

    public Pipe(string product,double diameter, double length) : base(product)
    {
        this.Diameter = diameter;
        this.Length = length;
    }

    public override string GetInfo()
    {
        return Product + " Diameter " + Diameter + ", längd: " + Length;
    }
}
