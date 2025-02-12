using SpreadEx_Test_Project.Widgets.@base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadEx_Test_Project.Widgets
{
    // Square widget
    public class Square : Widget
    {
        public int Side { get; set; }

        public Square(int x, int y, int side) : base(x, y)
        {
            Side = side;
        }

        public override void Draw()
        {
            Console.WriteLine($"Square at ({X},{Y}) - size: {Side}");
        }
    }
}
