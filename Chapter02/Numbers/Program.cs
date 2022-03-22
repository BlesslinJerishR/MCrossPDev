namespace Numbers
{
    class Program{
        static void Main(string[] args)
        {
            // unsigned integers means positive whole numbers
        // including 0
        uint naturalNumber = 23;

        // integers means negative or positive whole number
        // including 0
        int integerNumber = -23;

        // Float means single precision floating point
        // F suffix make it a float literal
        float realNumber = 2.3F;

        // double means double precision floating point
        double anotherRealNumber = 2.3; // double literal

        System.Console.WriteLine(naturalNumber);
        System.Console.WriteLine(integerNumber);
        System.Console.WriteLine(realNumber);
        System.Console.WriteLine(anotherRealNumber);
        System.Console.WriteLine("Three variables called on the same line : ");
        System.Console.WriteLine($"{naturalNumber}\n{realNumber}\n{anotherRealNumber}");

        // Three variable that store the number 2 million
        int decimalNotation = 2_000_000;
        int binaryNotation  = 0b_0001_1110_1000_0100_1000_0000;
        int hexadecimalNotation = 0x_001E_8480;

        // To check the three variables have the same value
        // both statement outputs true
        System.Console.WriteLine(decimalNotation == binaryNotation);
        System.Console.WriteLine(decimalNotation == hexadecimalNotation);

        System.Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:NO} to {int.MaxValue:NO}.");
        Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:NO} to {double.MaxValue:NO}.");
        Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:No} to {decimal.MaxValue:NO}.");
        
        Console.WriteLine($"Using doubles : ");
        double a = 0.1;
        double b = 0.2;

        if (a+b == 0.3)
        {
            Console.WriteLine($"{a} + {b} equals 0.3");

        }
        else
        {
            Console.WriteLine($"{a} + {b} does not equals 0.3");
            
        }   

        Console.WriteLine($"Using decimals : ");
        decimal c = 0.1M;
        decimal d = 0.2M;

        if (c+d == 0.3M)
        {
            Console.WriteLine($"{c} + {d} equals 0.3");
            
        }
        else
        {
            Console.WriteLine($"{c} + {d} does NOT equal 0.3");
            
        }           

        bool happy = true;
        bool sad = false;
        if (happy)
        {
            Console.WriteLine($"I am Happy");
            
        }
        if (!sad)
        {
            Console.WriteLine($"I am not sad");
            
        }
        }
    }
}