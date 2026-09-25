using System;
class Program
{
    public static void Main(string[] args)
    {
        Point A = new Point();
        Console.WriteLine("=== NHAP DIEM A ===");
        A.Nhap();
        Point B = new Point();
        Console.WriteLine("=== NHAP DIEM B ===");
        B.Nhap();
        Console.WriteLine("\n=== CAC DIEM ===");
        Console.WriteLine("A = " + A);
        Console.WriteLine("B = " + B);
        Point c = A+B;
        Console.WriteLine("\n A+B: "+c);
        Point D = A-B;
        Console.WriteLine("\n A-B: "+D);
        Point E = -A;
        Console.WriteLine("\n -A: "+E);
        double kc1 = A.KhoangCach(B);
        Console.WriteLine("\nKhoang cach (thanh vien) = " + kc1);
        double kc2 = Point.KhoangCach(A,B);
        Console.WriteLine("Khoang cach (tinh) = " + kc2);
        Point I1 = A.Trungdiem(B);
        Console.WriteLine("\nTrung diem (thanh vien) = " + I1);
        Point I2 = Point.TrungDiem(A,B);
         Console.WriteLine("Trung diem (tinh) = " + I2);
    }
}
