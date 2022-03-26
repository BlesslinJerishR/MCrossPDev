using static System.Console;
WriteLine("This Program is working");

for(int i=1; i<=10; i++)
{
    WriteLine(i);
}

List<string> names = new List<string>(){ "Adam", "Barry", "Charlie" };
foreach(string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}

WriteLine();

IEnumerator<string> e = names.GetEnumerator();
while(e.MoveNext())
{
    string name = (string)e.Current;
    WriteLine($"{name} has {name.Length} characters.");
}