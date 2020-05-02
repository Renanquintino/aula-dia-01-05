using Program__Class_135.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using Program__Class_135.Entities.Enum;


namespace Program__Class_135
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> list = new List<Shape>();


            Console.Write("Enter the number Shape");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} Data");
                Console.WriteLine("Rectangle or Circle?(r/c)");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Color Black/Blue/Red?");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (ch == 'r' || ch == 'R')
                {
                    Console.Write(" Width:  ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("  Height:");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));


                    
                }
                else 
                {
                    Console.Write(" Radiuns:  ");
                    double radiuns = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radiuns, color));


                }
               


            }
            Console.WriteLine("SHAPE AREA");
            Console.WriteLine();
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2",CultureInfo.InvariantCulture));
            }
        }
    }
}
