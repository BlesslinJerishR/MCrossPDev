using static System.Console;
Console.WriteLine("This program is working");
int a = 3;
int b = a++;
WriteLine($"a is {a} and b is {b}");

int c = 3;
int d = ++c;
WriteLine($"c is {c} and d is {d}");

int e = 11;
int f = 3;
WriteLine($"e is {e} and f is {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");

double g = 11.0;
WriteLine($"g is {g:N1}, f is {f}");
WriteLine($"g / f = {g / f}");

int p = 6;
WriteLine($"Orgin Value of p is {p}");
p += 3;
WriteLine($"Value of p + 3 is {p}");
p -= 3;
WriteLine($"Value of p - 3 is {p}");
p *= 3;
WriteLine($"Value of p * 3 is {p}");
p /= 3;
WriteLine($"Value of p / 3 is {p}");
