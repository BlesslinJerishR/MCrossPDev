using static System.Console;
WriteLine("This Program is working");

WriteLine("Before Parsing");
Write("What is your age ? ");
string input = ReadLine();
try
{
    int age = int.Parse(input);
    WriteLine($"You are {age} years old");
}
catch(OverflowException)
{
    WriteLine($"Your age is a number but its either too big or small");
}
catch (FormatException)
{
    WriteLine("The age you entered is not a valid number format.");
}
// To Catch all exceptions
catch(Exception ex)
{
    WriteLine($"{ex.GetType().Name} says {ex.Message}");
}
WriteLine("After Parsing");