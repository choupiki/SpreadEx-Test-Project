using SpreadEx_Test_Project.Widgets.@base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadEx_Test_Project.Widgets
{
    // Textbox widget
    public class Textbox : Widget
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public string Text { get; set; }

        public Textbox(int x, int y, int width, int height, string text) : base(x, y)
        {
            Width = width;
            Height = height;
            Text = text;
        }

        public override void Draw()
        {
            Console.WriteLine($"Textbox at ({X},{Y}) - Width: {Width}, Height: {Height}, Text: {Text}");
        }
    }
}
