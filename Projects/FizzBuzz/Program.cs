using static System.Console;
WriteLine("Fizz-Buzz");
bool game = true;
while(game)
{
    Write("Enter a number : ");
    string num = ReadLine();
    int number = int.Parse(num);
    try
    {
        if(number % 3 == 0 && number % 5 == 0)
        {
            WriteLine("Fizz-Buzz");
        }
        else if(number % 3 == 0)
        {
            WriteLine("Fizz");
        }
        else if(number % 5 == 0)
        {
            WriteLine("Buzz");
        }
    }
    catch
    {
         // I am catching all the exceptions
    }
} 
