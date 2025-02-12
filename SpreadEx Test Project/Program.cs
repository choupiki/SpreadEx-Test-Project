using SpreadEx_Test_Project;
using SpreadEx_Test_Project.Widgets;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        DrawingApp app = new DrawingApp();

        // Creating required widgets
        app.AddWidget(new Rectangle(x: 10, y: 10, width: 30, height: 40));
        app.AddWidget(new Square(x: 15, y: 30, side: 35));
        app.AddWidget(new Ellipse(x: 100, y: 150, horizontalDiameter: 300, verticalDiameter: 200));
        app.AddWidget(new Circle(x: 1, y: 1, diameter: 300));
        app.AddWidget(new Textbox(x: 5, y: 5, width: 200, height: 100, "sample text"));

        // Drawing all widgets
        app.DrawAllWidgets();

        // Keep the console window open
        Console.ReadLine();
    }
}
