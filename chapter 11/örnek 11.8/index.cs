using System;

namespace GeometryApp
{
    // 1. Seviye: Temel Sınıf
    public class Quadrilateral
    {
        // Private instance variables (Koordinat çiftleri)
        private double x1, y1, x2, y2, x3, y3, x4, y4;

        public Quadrilateral(double x1, double y1, double x2, double y2, 
                             double x3, double y3, double x4, double y4)
        {
            this.x1 = x1; this.y1 = y1;
            this.x2 = x2; this.y2 = y2;
            this.x3 = x3; this.y3 = y3;
            this.x4 = x4; this.y4 = y4;
        }

        // Koordinatlara güvenli erişim için property'ler
        public double X1 => x1; public double Y1 => y1;
        public double X2 => x2; public double Y2 => y2;
        public double X3 => x3; public double Y3 => y3;
        public double X4 => x4; public double Y4 => y4;

        public override string ToString() => 
            $"({X1}, {Y1}), ({X2}, {Y2}), ({X3}, {Y3}), ({X4}, {Y4})";
    }

    // 2. Seviye: Yamuk
    public class Trapezoid : Quadrilateral
    {
        public Trapezoid(double x1, double y1, double x2, double y2, 
                         double x3, double y3, double x4, double y4) 
            : base(x1, y1, x2, y2, x3, y3, x4, y4) { }

        public virtual double GetHeight() => Math.Abs(Y1 - Y3);

        public virtual double GetArea()
        {
            double base1 = Math.Abs(X1 - X2);
            double base2 = Math.Abs(X3 - X4);
            return ((base1 + base2) * GetHeight()) / 2.0;
        }
    }

    // 3. Seviye: Paralelkenar
    public class Parallelogram : Trapezoid
    {
        public Parallelogram(double x1, double y1, double x2, double y2, 
                             double x3, double y3, double x4, double y4) 
            : base(x1, y1, x2, y2, x3, y3, x4, y4) { }

        public double GetWidth() => Math.Abs(X1 - X2);

        public override double GetArea() => GetWidth() * GetHeight();
    }

    // 4. Seviye: Dikdörtgen
    public class Rectangle : Parallelogram
    {
        public Rectangle(double x1, double y1, double x2, double y2, 
                         double x3, double y3, double x4, double y4) 
            : base(x1, y1, x2, y2, x3, y3, x4, y4) { }

        public override double GetArea()
        {
            double length = Math.Abs(X1 - X2);
            double width = Math.Abs(Y1 - Y4);
            return length * width;
        }
    }

    // 5. Seviye: Kare
    public class Square : Rectangle
    {
        public Square(double x1, double y1, double x2, double y2, 
                      double x3, double y3, double x4, double y4) 
            : base(x1, y1, x2, y2, x3, y3, x4, y4) { }

        public override double GetArea()
        {
            double side = Math.Abs(X1 - X2);
            return side * side;
        }
    }

    // Test Uygulaması
    class Program
    {
        static void Main(string[] args)
        {
            // Nesnelerin Örneklenmesi
            Trapezoid trapezoid = new Trapezoid(0, 0, 10, 0, 8, 5, 2, 5);
            Parallelogram parallelogram = new Parallelogram(5, 5, 11, 5, 12, 10, 6, 10);
            Rectangle rectangle = new Rectangle(17, 14, 30, 14, 30, 28, 17, 28);
            Square square = new Square(4, 4, 8, 4, 8, 8, 4, 8);

            // Çıktılar
            Console.WriteLine("Dörtgen Hiyerarşisi Alan Hesaplamaları:\n");
            Console.WriteLine($"Yamuk Alanı: {trapezoid.GetArea()}");
            Console.WriteLine($"Paralelkenar Alanı: {parallelogram.GetArea()}");
            Console.WriteLine($"Dikdörtgen Alanı: {rectangle.GetArea()}");
            Console.WriteLine($"Kare Alanı: {square.GetArea()}");
            
            Console.ReadKey();
        }
    }
}