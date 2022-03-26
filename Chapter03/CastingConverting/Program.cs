using static System.Console;
using static System.Convert;

WriteLine("This program is working.");

int a = 100;
double b = a;
WriteLine(a);
WriteLine(b);

double c = 10.5;
double e = 10.9;
// int d = c;
int d = (int)c;
int f = (int)e;
WriteLine(c);
WriteLine(d);
WriteLine(f);

long g = 10;
int h = (int)g;
WriteLine($"e is {g:N0} and h is {h:N0}");
g = long.MaxValue;
h = (int)g;
WriteLine($"g is {g:N0} and h is {h:N0}");

double j = 9.8;
int k = ToInt32(j);
WriteLine($"j is {j} and k is {k}");

double[] doubles = new[]{9.49, 9.5, 9.51, 10.49, 10.5, 10.51};

foreach (double doub in doubles)
{
    WriteLine($"ToInt({doub}) is {ToInt32(doub)}");
}

WriteLine();

int number = 12;
WriteLine(number.ToString());

bool boolean = true;
WriteLine(boolean.ToString());

DateTime now = DateTime.Now;
WriteLine(now.ToString());

object me = new object();
WriteLine(me.ToString());

WriteLine();

int age = int.Parse("27");
DateTime birthday = DateTime.Parse("4 December 2000");

WriteLine($"I was born {age} years ago.");
WriteLine($"My birthday is {birthday}.");
WriteLine($"My birthday is {birthday:D}.");

Write("How many eggs are there ? ");
int count;
string input = ReadLine();

if(int.TryParse(input, out count))
{
    WriteLine($"There are {count} eggs.");
}
else{
    WriteLine($"I could not parse the input.");
}

