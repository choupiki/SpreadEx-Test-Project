using SpreadEx_Test_Project.Widgets.@base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadEx_Test_Project.Widgets
{
    // Rectangle widget
    public class Rectangle : Widget
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int x, int y, int width, int height) : base(x, y)
        {
            Width = width;
            Height = height;
        }

        public override void Draw()
        {
            Console.WriteLine($"Rectangle at ({X},{Y}) - Width: {Width}, Height: {Height}");
        }
    }
}
