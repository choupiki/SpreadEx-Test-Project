using SpreadEx_Test_Project.Widgets.@base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadEx_Test_Project.Widgets
{
    // Ellipse widget
    public class Ellipse : Widget
    {
        public int HorizontalDiameter { get; set; }
        public int VerticalDiameter { get; set; }

        public Ellipse(int x, int y, int horizontalDiameter, int verticalDiameter) : base(x, y)
        {
            HorizontalDiameter = horizontalDiameter;
            VerticalDiameter = verticalDiameter;
        }

        public override void Draw()
        {
            Console.WriteLine($"Ellipse at ({X},{Y}) - DiameterH: {HorizontalDiameter}, DiameterV: {VerticalDiameter}");
        }
    }
}
