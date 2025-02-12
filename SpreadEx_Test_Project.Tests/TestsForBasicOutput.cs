using System.Reflection.Metadata;
using SpreadEx_Test_Project.Widgets;

namespace SpreadEx_Test_Project.Tests
{
    using System;
    using Xunit;

    public class WidgetTests
    {
        [Fact]
        public void Rectangle_Draw_ReturnsCorrectOutput()
        {
            // Arrange
            var rectangle = new Rectangle(1, 2, 10, 20);

            // Act
            var output = CaptureOutput(() => rectangle.Draw());

            // Assert
            Assert.Equal("Rectangle at (1,2) - Width: 10, Height: 20", output);
        }

        [Fact]
        public void Square_Draw_ReturnsCorrectOutput()
        {
            // Arrange
            var square = new Square(2, 3, 15);

            // Act
            var output = CaptureOutput(() => square.Draw());

            // Assert
            Assert.Equal("Square at (2,3) - Side: 15", output);
        }

        [Fact]
        public void Ellipse_Draw_ReturnsCorrectOutput()
        {
            // Arrange
            var ellipse = new Ellipse(3, 4, 20, 10);

            // Act
            var output = CaptureOutput(() => ellipse.Draw());

            // Assert
            Assert.Equal("Ellipse at (3,4) - Horizontal Diameter: 20, Vertical Diameter: 10", output);
        }

        [Fact]
        public void Circle_Draw_ReturnsCorrectOutput()
        {
            // Arrange
            var circle = new Circle(5, 6, 12);

            // Act
            var output = CaptureOutput(() => circle.Draw());

            // Assert
            Assert.Equal("Circle at (5,6) - Diameter: 12", output);
        }

        [Fact]
        public void Textbox_Draw_ReturnsCorrectOutput()
        {
            // Arrange
            var textbox = new Textbox(7, 8, 30, 10, "Hello World");

            // Act
            var output = CaptureOutput(() => textbox.Draw());

            // Assert
            Assert.Equal("Textbox at (7,8) - Width: 30, Height: 10, Text: Hello World", output);
        }

        // Helper method to capture console output
        private string CaptureOutput(Action action)
        {
            var originalConsoleOut = Console.Out;
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                action.Invoke();
                return sw.ToString().Trim();
            }
        }
    }

}