using System; // Gives access to built-in functions like Console.WriteLine

namespace Classes_Watford_Koby // Must match the namespace of the Program class
{
    public class Greetings // Public class that can be accessed from other classes
    {
        // Public method that displays a welcome message to the console
        public void Welcome()
        {
            // Prints a welcome message
            Console.WriteLine("Welcome to our C# program! Glad to have you here.");
        }

        // Public method that takes a string parameter and prints a custom greeting
        public void Hello(string name)
        {
            // Uses string interpolation to insert the name into the message
            Console.WriteLine($"{name}, thank you for joining us today!");
        }
    }
}
