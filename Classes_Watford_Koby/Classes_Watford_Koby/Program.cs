using System; // Allows us to use built-in system functions like Console.WriteLine

namespace Classes_Watford_Koby // Our custom namespace, helps organize code
{
    class Program // Main class where program execution starts
    {
        static void Main(string[] args) // Main method, the entry point of the program
        {
            // Create an object (instance) of the Greetings class
            Greetings greetings = new Greetings();

            // Call the Welcome method from the Greetings class
            greetings.Welcome();

            // Call the Hello method and pass a name string to it
            greetings.Hello("Koby");
        }
    }
}
