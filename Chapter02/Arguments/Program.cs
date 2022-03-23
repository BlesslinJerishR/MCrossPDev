using System;
using static System.Console;

namespace Arguments{
    class Program{
        static void Main(string[] args)
        {
            WriteLine("This Program is working");
            WriteLine($"There are {args.Length} arguments");
            int num = 1;
            foreach (string arg in args){
                WriteLine($"Argument {num} : {arg}");   
                num += 1;
            }

            if(args.Length < 4){
                WriteLine("You must specify 2 colors and Dimensions, eg : ");
                WriteLine("dotnet run red yellow 80 40");
                return; //stop running
            }

            ForegroundColor = (ConsoleColor)Enum.Parse(
                enumType: typeof(ConsoleColor),
                value: args[0],
                ignoreCase: true
            );

            BackgroundColor = (ConsoleColor)Enum.Parse(
                enumType: typeof(ConsoleColor),
                value: args[1],
                ignoreCase: true
            );

            try{
                WindowWidth = int.Parse(args[2]);
                WindowHeight = int.Parse(args[3]);
            }
            catch(PlatformNotSupportedException){
                WriteLine("The Current platform does not support changing the size of the console window");
            }
            
        }
    }
}