using Program__Class_135.Entities;
using Program__Class_135.Entities.Enum;

namespace Program__Class_135.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

      

        public Shape(Color color)
        {
            Color = color;

        }

        public abstract double Area();
    }
}
