using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4.OOP
{
    class HandlingExceptions
    {
        private void ErrorHandling()
        {
            Console.WriteLine("Specify a file name:");
            string fileName = Console.ReadLine();
            FileStream myFile = null;
            try
            {
                myFile = new FileStream(fileName, FileMode.Open);
                // Seek a specific position in the file.
                // Just for example
                myFile.Seek(5, SeekOrigin.Begin);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"File {ex.FileName} not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unidentified error occurred: {ex.Message}");
            }
            finally
            {
                myFile?.Close();
            }

        }
    }
}
