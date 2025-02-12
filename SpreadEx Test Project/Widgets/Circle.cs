using SpreadEx_Test_Project.Widgets.@base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadEx_Test_Project.Widgets
{
    // Circle widget
    public class Circle : Widget
    {
        public int Diameter { get; set; }

        public Circle(int x, int y, int diameter) : base(x, y)
        {
            Diameter = diameter;
        }

        public override void Draw()
        {
            Console.WriteLine($"Circle at ({X},{Y}) - size: {Diameter}");
        }
    }
}
