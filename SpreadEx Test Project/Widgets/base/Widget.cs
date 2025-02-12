using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadEx_Test_Project.Widgets.@base
{
    // Base class for all widgets
    public abstract class Widget
    {
        public int X { get; set; }
        public int Y { get; set; }

        // Constructor to initialize the widget with coordinates
        protected Widget(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Each widget will implement its own drawing details 
        public abstract void Draw();
    }
}
