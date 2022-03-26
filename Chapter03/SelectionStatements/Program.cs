using System.IO;
using System;
using static System.Console;

Console.WriteLine("This program is working");

if(args.Length == 0)
{
    Console.WriteLine($"There are 0 Arguments");
}
else
{
    Console.WriteLine($"There is atleast one arguments");
}

// object o = "3"; // String type
object o = 3;
int j = 4;

if(o is int i)
{
    Console.WriteLine($"{i} x {j} = {i*j}");

}
else
{
    Console.WriteLine($"o is not an int so it cannot be multiplied");
    
}

A_label:
var number = (new Random().Next(1,7));
Console.WriteLine($"My Random number is {number}");

switch (number)
{
    case 1:
        Console.WriteLine($"One");
        break;
    case 2:
        Console.WriteLine($"Two");
        goto case 1;
    case 3:
    case 4:
        Console.WriteLine($"Three or Four");
        goto case 1;
    case 5:
        // Sleep for 0.5 Seconds
        Console.WriteLine($"5 wait for 0.5 seconds");
        System.Threading.Thread.Sleep(500);
        goto A_label;
    default:
        Console.WriteLine($"I am 6 , retry");
        break;
}

string path = @"C:\Users\blesslinj\Documents\GitHub\MCrossPDev\Chapter03";
Write("Press R for readonly or W for write: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();

Stream s = null;

if(key.Key == ConsoleKey.R)
{
    s = File.Open(
        Path.Combine(path, "file.txt"),
        FileMode.OpenOrCreate,
        FileAccess.Read
    );
}
else{
    s = File.Open(
        Path.Combine(path, "file.txt"),
        FileMode.OpenOrCreate,
        FileAccess.Write
    );
}

string message = string.Empty;

switch(s)
{
    case FileStream writeableFile when s.CanWrite:
         message = "The stream is a file that i can write to.";
         break;

    case FileStream readOnlyFile:
         message = "The stream is read only file.";
         break;

    default: //always evaluated last        
         message = "The stream is some other type.";
         break;
    case null:
         message = "The stream is null.";
         break;
}
WriteLine(message);

message = s switch
{
    FileStream writeableFile when s.CanWrite
        => "The stream is a file that i can write to.",
    FileStream readOnlyFile
        => "The stream is read only file.",
    MemoryStream ms
        => "The stream is a memory address.",
    null
        => "The stream is null.",
    _
        => "The stream is some other type."
};
WriteLine(message);

ReadLine();