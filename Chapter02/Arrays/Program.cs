using System;

namespace Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"This file is working");
            
            string[] names;
            names = new string[4];
            names[0] = "Jerry";
            names[1] = "Tom";
            names[2] = "Koti";
            names[3] = "kalai";

            // Looping through names
            for (var i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"name {i+1} : {names[i]}");
                
            }
        }
    }
}