**Readme**

**Overview**
This Drawing Package Console Application simulates a drawing program that supports several basic drawing primitives (referred to as widgets). The program allows users to add widgets (shapes and textboxes) to a drawing, and prints the details of these widgets to the console. The application follows SOLID design principles to ensure maintainability and extensibility.

**Supported Widgets:**
Rectangle: A rectangular shape with a specified width and height.
Square: A square shape with a specified side length.
Ellipse: An elliptical shape with a specified horizontal and vertical diameter.
Circle: A circular shape with a specified diameter.
Textbox: A text box with a bounding rectangle that holds the text.
The program showcases how to create a modular and extensible drawing package that allows for easy addition of new widgets while adhering to object-oriented design principles.

**Features**
Add Widgets: The program can add various widgets to the drawing.
Draw Widgets: The details of the widgets (location, size, and type) are printed to the console.

SOLID Principles: The design of the application demonstrates the SOLID principles, including:
	Single Responsibility Principle (SRP): Each class has a single responsibility.
	Open/Closed Principle (OCP): The system is open for extension but closed for modification.
	Liskov Substitution Principle (LSP): Derived classes can replace their base class without altering the correctness of the program.
	Interface Segregation Principle (ISP): Classes implement interfaces they need, minimizing the complexity of dependencies.
	Dependency Inversion Principle (DIP): High-level modules depend on abstractions.

**Requirements**
.NET 5.0 or higher: Ensure you have the latest version of .NET installed.
xUnit (for testing): The program includes unit tests to verify the functionality of the core features.

**Discussion**
The widgets in the project are based off of a base class _widget_. The functions within each widget override the function _Draw()_ of the base class, this is to follow SOLID design principles and make for clean code.
Widgets have been separated into a folder to ensure a clean and organised solution for the project. In the primary business class of the program, _DrawingApp_, the real benefit of using the base class _widget_ can be seen. A list of any of the classes with a base class of _widget_ (_Circle_, _Square_, _Rectangle_, _Ellipse_, _Textbox_) can be built up with desired parameters for each respectively. 
Following this, a call can be made to _DrawAllWidgets()_ which runs through and runs _Draw()_ on each of the items in the list. The fact that each widget has its own override of the same function which handles its bespoke needs, allows for very effective and clean code to be written here. 
If each inidividual widget was of a unique and separate class the function would require many initialisations and calls to each of these classes, leading to a cluttered and inefficient codebase.

**Further Enhancements and Improvements**
With a greater amount of time and more scope for this project there are a few enhancements that could be made. 

	1. Allow for user input. It would be interesting and more exciting for the user to be able to input their own dimensions for the shapes to be created. Users could then output customisable shapes when and if they wanted to. Perhaps a menu could be added to allow for either default or custom dimensions.
	2. Add mathematical functionality. To make the program more useful functionality allowing it to calculate various data about the shapes could be added. For example, if a user were to input all dimensions it would be trivial to add an output to the program which detailed the area/perimeter of the shapes created. Another useful feature would be to allow the user to input data which the original inputs could be inferred from (to allow a reverse calculation) e.g. input the circumference of the circle and return the diameter.
	3. Render a small plain text drawing. It would be more engaging (and quite kitsch) for the user to see a small drawing of each shape, rendered in unicode characters, that the program outputs. This could also help dyslexic or dyscalculic individuals visualise the shapes properly.