using System;
using System.IO;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // A text message to be displayed
            string textMessage = "Hello World!";

            // Attempting to open a file that does not exist
            string textFileContent = File.ReadAllText(@"C:\MyFile.txt");

            // Displaying a text message
            Console.WriteLine(textMessage);

            // Waiting for the user input
            Console.ReadLine();
        }
    }
}
