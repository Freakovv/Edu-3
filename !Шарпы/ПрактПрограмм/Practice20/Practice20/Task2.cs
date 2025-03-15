using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace Practice20
{
    namespace Figures
    {
        [XmlInclude(typeof(Rectangle))]
        [XmlInclude(typeof(Parallelepiped))]
        public abstract class Figure
        {
            public abstract double GetPerimeter();
            public abstract double GetArea();
            public abstract double GetVolume();
        }

        public class Rectangle : Figure
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public Rectangle() { }

            public Rectangle(double width, double height)
            {
                Width = width;
                Height = height;
            }

            public override double GetPerimeter() => 2 * (Width + Height);

            public override double GetArea() => Width * Height;

            public override double GetVolume() => 0;

            public override string ToString()
            {
                return $"Прямоугольник: {Width} x {Height} | Периметр: {GetPerimeter()} | Площадь: {GetArea()}";
            }
        }

        public class Parallelepiped : Rectangle
        {
            public double Depth { get; set; }

            public Parallelepiped() { }

            public Parallelepiped(double width, double height, double depth)
                : base(width, height)
            {
                Depth = depth;
            }

            public override double GetPerimeter() => 4 * (Width + Height + Depth);

            public override double GetArea() => 2 * (Width * Height + Width * Depth + Height * Depth);

            public override double GetVolume() => Width * Height * Depth;

            public override string ToString()
            {
                return $"Параллелепипед: {Width} x {Height} x {Depth} | Периметр: {GetPerimeter()} | Площадь: {GetArea()} | Объем: {GetVolume()}";
            }
        }
    }

}
