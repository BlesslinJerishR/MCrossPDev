using static System.Console;
using System;

WriteLine("This program is working");

int x = 0;
while(x<10)
{
    WriteLine(x);
    x++;
}

WriteLine();

string password = string.Empty;
int count = 0;
do
{
    Write("Enter your password: ");
    password = ReadLine();
    count += 1;
    if (password == "Pa$$w0rd")
    {
        WriteLine("Password is Correct");
        break;
    }
    if(count == 3)
    {
        WriteLine("Login attempts Exceeded");
        break;
    }
    
}
while(password != "Pa$$w0rd");

