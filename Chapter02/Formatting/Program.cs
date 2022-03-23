using static System.Console;

WriteLine("This program is working");

int numberOfApples = 12;
decimal pricePerApple = 0.35M;

// Long method
WriteLine("{0} apples costs {1:C}",
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
WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");

string applesText = "Apples";
int applesCount = 1234;

string bananasText = "Bananas";
int bananasCount = 56789;

WriteLine(
    format: "{0,-8} {1,6:NO}",
    arg0: "Name",
    arg1: "Count"
);

//Bug
WriteLine(
    format: "{0,-8} {1,6:NO}",
    arg0: applesText,
    arg1: applesCount);

// Bug
WriteLine(
    format: "{0,-8} {1,6:NO}",
    arg0: bananasText,
    arg1: bananasCount
);

WriteLine($"Name\tCount");
WriteLine($"{applesText}\t{applesCount}");
WriteLine($"{bananasText}\t{bananasCount}");

Write("Type your name and press Enter : ");
string name = ReadLine();

Write("Type your age  and press Enter : ");
string age = ReadLine();

WriteLine($"Hello {name}, Your age is {age}.");

Write("Press Any key combination : ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine($"The pressed key is : {key.Key} Char : {key.KeyChar} Modifiers : {key.Modifiers}");
