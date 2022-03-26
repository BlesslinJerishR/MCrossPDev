using static System.Console;
Console.WriteLine("This program is working");

int a = 10;
int b = 6;
WriteLine($"a = {a}");
WriteLine($"b = {b}");
WriteLine($"a & b = {a & b}");
WriteLine($"a | b = {a | b}");
WriteLine($"a ^ b = {a ^ b}");

WriteLine($"a << 3 = {a << 3}");
WriteLine($"a * 8 = {a * 8}");
WriteLine($"b >> 1 = {b >> 1}");

int age = 47;
char firstDigit = age.ToString()[0];

a = 1;
b = 2;
WriteLine($"A = {a}");
WriteLine($"B = {b}");

if(a+b==3)
{
WriteLine($"A + B is 3");
}
else if(a-b==4)
{
    WriteLine($"A - B is 4");
}
else{
    WriteLine($"A &  B are not a numbers");
}

