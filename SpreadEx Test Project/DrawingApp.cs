using SpreadEx_Test_Project.Widgets.@base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadEx_Test_Project
{
    // Drawing Application class - Handles the management of widgets
    public class DrawingApp
    {
        private List<Widget> widgets = new List<Widget>();

        // Adds widgets to the drawing 
        public void AddWidget(Widget widget)
        {
            widgets.Add(widget);
        }

        // Draws all widgets
        public void DrawAllWidgets()
        {
            DrawDashes();

            Console.WriteLine("Requested Drawing:");

            DrawDashes();

            foreach (var widget in widgets)
            {
                widget.Draw();
            }

            DrawDashes();
        }

        /// <summary>
        /// Draws a line of dashes across console window
        /// </summary>
        private static void DrawDashes()
        {
            int width = Console.WindowWidth;

            // Create a string of dashes with the same length as the console width
            string dashes = new string('-', width);

            Console.Write(dashes);
        }
    }

}
