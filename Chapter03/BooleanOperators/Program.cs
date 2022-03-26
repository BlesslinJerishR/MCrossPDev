using static System.Console;

namespace BooleanOperators{
    class Program{
        static void Main(string[] args)
        {

            Console.WriteLine("This program is working");
            WriteLine("");
            bool a = true;
            bool b = false;
            WriteLine($"AND | a     | b ");
            WriteLine($"a   | {a & a, -5} | {a & b, -5} ");
            WriteLine($"b   | {b & a, -5} | {b & b, -5} ");
            WriteLine($"");
            WriteLine($"OR | a     | b ");
            WriteLine($"a   | {a | a, -5} | {a | b, -5} ");
            WriteLine($"b   | {b | a, -5} | {b | b, -5} ");
            WriteLine($"");
            WriteLine($"XOR | a     | b ");
            WriteLine($"a   | {a ^ a, -5} | {a ^ b, -5} ");
            WriteLine($"b   | {b ^ a, -5} | {b ^ b, -5} ");
            WriteLine($"");

            WriteLine($"a & DoStuff() = {a & DoStuff()}");
            WriteLine($"b & DoStuff() = {b & DoStuff()}");

            WriteLine($"a && DoStuff() = {a && DoStuff()}");
            WriteLine($"b && DoStuff() = {b && DoStuff()}");
        }

        private static bool DoStuff(){
                WriteLine($"I am doing some stuff");
                return true;
            }
    }
}






