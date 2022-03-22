using System;
using System.Linq;
using System.Reflection;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello C# by Blesslin Jerish R");
            System.Console.WriteLine("Hi Jerry");
            System.Console.WriteLine();
            System.Console.WriteLine(
                "Temperature on {0:D} is {1} degree C", DateTime.Today, 23.4);
            // Declare some unused variables using Types
            // in Additional assemblies
            System.Data.DataSet ds;
            System.Net.Http.HttpClient client;
            // Loop through the assemblies that this app references
            foreach (var r in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                // Load the assemblies so we can read it in details
                var a = Assembly.Load(new AssemblyName(r.FullName));

                // Declare a variable to count the number of methods
                int methodCount = 0;

                // Loop through all the types in the assembly
                foreach(var t in a.DefinedTypes){
                    // add up the count of methods
                    methodCount += t.GetMethods().Count();
                }
                // Output the count of types and their methods
                System.Console.WriteLine(
                    "{0:NO} types with {1:NO} methods in {2} assembly.",
                    arg0: a.DefinedTypes.Count(),
                    arg1: methodCount,
                    arg2: r.Name
                );
            }
            // let the heightInMetres variable become equal to the value 1.88
            double heightInMetres = 1.88;
            System.Console.WriteLine($"The variable {nameof(heightInMetres)} has the value {heightInMetres}.");

            // Storing texts
    
            char letter = 'A'; // Assigning literal characters
            char digit = '1';
            char symbol = '$';
            System.Console.WriteLine(letter);
            System.Console.WriteLine(digit);
            System.Console.WriteLine(symbol);
            // char userChoice = GetKeyStroke(); // Assigning from a function
            // Assigning literal strings
            string firstName = "Bob";
            string lastName = "Smith";
            string phoneNumber = "(+91) 9878878767";
            System.Console.WriteLine(firstName);
            System.Console.WriteLine(lastName);
            System.Console.WriteLine(phoneNumber);
            //assigning a string returned from a function call
            // string address = GetAddressFromDatabase(id: 563);
            
            string fullNameWithTabSeperator = "Bob\tSmith";
            System.Console.WriteLine(fullNameWithTabSeperator);

            string filepath = @"C:\televisions\sony\bravia.txt";
            System.Console.WriteLine(filepath);
        }
    }}
