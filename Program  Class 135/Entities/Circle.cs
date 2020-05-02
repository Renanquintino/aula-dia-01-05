

using Program__Class_135.Entities.Enum;
using System;

namespace Program__Class_135.Entities
{
    class Circle : Shape
        
    {
        public double Radiuns { get; set; }

        public Circle(double radiuns, Color color)
            :base(color)
        {
            Radiuns = radiuns;
        }

        public override double Area()
        {
            return Math.PI * (Radiuns * Radiuns);
        }
    }
}
