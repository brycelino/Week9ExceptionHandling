using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Generic;
namespace Week9ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            
            validFormat();
            
        }
        static void validFormat()// method that determines if the users input is valid file path
        {
            
            
                Console.WriteLine("Please enter a file path: ");
                string userInput = Console.ReadLine();
                var numChecker = new Regex(@"^[A-Z]:\\??([A-Za-z0-9\s\\\&\@\\#\*])+([A-Za-z0-9.])([A-Za-z0-9]{3})$");
                if (numChecker.IsMatch(userInput))
                {
                    Console.WriteLine("File path is valid");
                try
                {

                    int wordCount = 0;
                    StreamReader sr = new StreamReader(userInput);
                    string line;
                    do
                    {
                        line = sr.ReadLine();
                        Console.WriteLine(line);
                        if (line != null)
                        {

                            wordCount += line.Split(' ').Length;

                        }
                        
                    } while (line != null);
                    
                    Console.WriteLine("There are a total of: " + wordCount + " words");





                }

                catch (Exception e)
                {
                    Console.WriteLine("Sorry " + e.Message + " Please try again.");
                }
            }
                else
                    Console.WriteLine("File path is invalid");
        }
    }
}
