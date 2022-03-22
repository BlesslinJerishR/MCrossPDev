using System.Xml;
using System;

namespace Variables
{
    class Program{
        static void Main(string[] args)
        {
            Console.WriteLine($"This file is working");
            
            object height = 1.88; // storing a double in the object
            object name = "Gokul"; // storing a string in an object
            
            Console.WriteLine($"{name} is {height} metres tall");
            
            // int length1 = name.Length; // Compile error
            int length1 = ((string)name).Length; // Tells compiler it is a string
            Console.WriteLine($"{name} has {length1} characters");
            
            // Storing a string in the dynamic object
            dynamic friend = "Kalai";
            int length = friend.Length;
            Console.WriteLine($"{friend} has {length} characters");

            int population = 66_000_000; // 66 million in uk
            double weight = 1.66; // Kilograms
            decimal price = 4.99M; // in pounds sterling
            string fruit = "Apples"; // strings use double quotes
            char letter = 'Z'; // chars use single-quotes
            bool available = true; // true or false

            var population0 = 66_000_000;
            var weight0 = 1.88;
            var price0 = 4.99;
            var fruit0 = "Apples";
            var letter0 = 'C';
            var balance0 = false;

            Console.WriteLine($"{population}");
            Console.WriteLine($"{population0}");

            // Good Use
            // var xml1 = new XmlDocument();
            // XmlDocument xml2 = new XmlDocument();

            // Bad Use
            // var file1 = File.CreateText(@"D:\something.txt");
            // StreamWriter file2 = File.CreateText(@"D:\something.txt");
            
            Console.WriteLine($"default(int) = {default(int)}");
            Console.WriteLine($"default(bool) = {default(bool)}");

            Console.WriteLine($"default(DateTime) = {default(DateTime)}");
            Console.WriteLine($"default(string) = {default(string)}");

            
            
            
        }
    }
}