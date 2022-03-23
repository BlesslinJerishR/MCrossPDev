Console.WriteLine("This program is working");

int numberOfApples = 12;
decimal pricePerApple = 0.35M;

// Long method
Console.WriteLine("{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples
);

// Base method
string formatted = string.Format(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples
);

//WriteToFile(formatted); // writes the string to file

//Interpolated strings
// Best Method
Console.WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");

string applesText = "Apples";
int applesCount = 1234;

string bananasText = "Bananas";
int bananasCount = 56789;

Console.WriteLine(
    format: "{0,-8} {1,6:NO}",
    arg0: "Name",
    arg1: "Count"
);

//Bug
Console.WriteLine(
    format: "{0,-8} {1,6:NO}",
    arg0: applesText,
    arg1: applesCount);

// Bug
Console.WriteLine(
    format: "{0,-8} {1,6:NO}",
    arg0: bananasText,
    arg1: bananasCount
);

Console.WriteLine($"Name\tCount");
Console.WriteLine($"{applesText}\t{applesCount}");
Console.WriteLine($"{bananasText}\t{bananasCount}");

Console.Write("Type your name and press Enter : ");
string name = Console.ReadLine();

Console.Write("Type your age  and press Enter : ");
string age = Console.ReadLine();

Console.WriteLine($"Hello {name}, Your age is {age}.");
