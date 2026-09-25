using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
public class Point
{
    private int x;
    private int y;
    public Point()
    {
        x =0;
        y =0;
    }
    public int Pointx
    {
        get{return x;}
        set{x=value;}
    }
     // PROPERTY
    public int Pointy
    {
        get{return y;}
        set{y=value;}
    }
    public void Nhap()
    {
        Console.WriteLine("Nhap x: ");
        x=int.Parse(Console.ReadLine()??string.Empty);
         Console.WriteLine("Nhap y: ");
        y=int.Parse(Console.ReadLine()??string.Empty);
    }
    public void Xuat()
    {
        Console.WriteLine( +x +","+y );
    }
    // OVERRIDE TOSTRING
    public override string ToString()
    {
        return +x+","+y;
    }
    // PHÉP +
    public static Point operator +(Point A, Point B)
    {
        
    }
}