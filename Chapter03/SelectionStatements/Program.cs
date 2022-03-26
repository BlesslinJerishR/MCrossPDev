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
Console.ReadLine();

