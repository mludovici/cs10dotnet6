
using System.Xml;
using static System.Console;



decimal a = 0.000000001M;
decimal b = 0.000000002M;
dynamic result = a + b;
dynamic something = new[] { 1, 2, 3 };
XmlDocument xml3 = new();
Console.WriteLine(xml3);
Console.WriteLine(default(string));

Person kim = new();
kim.BirthDate = new(1967, 12, 26); //

int numberOfApples = 12;
decimal pricePerApple = 0.35M;
Console.WriteLine(
format: "{0} apples costs {1:C}",
arg0: numberOfApples,
arg1: pricePerApple * numberOfApples);
string formatted = string.Format(
format: "{0} apples costs {1:C}",
arg0: numberOfApples,
arg1: pricePerApple * numberOfApples);
//WriteToFile(formatted); // writes the string into a file




Console.OutputEncoding = System.Text.Encoding.UTF8;

var encoding = System.Text.Encoding.GetEncodings();
Console.WriteLine($"encoding: {encoding}");
foreach (var enc in encoding)
{
	Console.WriteLine($"{enc.CodePage}, {enc.DisplayName}");
}


StreamWriter file2 = File.CreateText("something2.txt");
file2.WriteLine($"{numberOfApples} apples cost {numberOfApples * pricePerApple:C}");
file2.Close();
Console.WriteLine($"{numberOfApples} apples cost {numberOfApples * pricePerApple:C}");


int c = 16;
int d = 3;
Console.WriteLine($"{d >> 1}");
Console.WriteLine($"a<<3: {c << 3}");

string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;

string zahl = Console.ReadLine();
bool tryP = int.TryParse(zahl, out int count);
Console.WriteLine($"Zahl ist: {tryP} und {count}");

try
{
	string? input = Console.ReadLine();
	int ff = int.Parse(input);

}
catch (Exception ex)
{
	WriteLine($"{ex.GetType()} says {ex.Message}");
}

// let doubleZahl = double.Parse(zahl);

Console.WriteLine(
format: "{0,-10} {1,6:N0}",
arg0: "Name",
arg1: "Count");
Console.WriteLine(
format: "{0,-10} {1,6:N2}",
arg0: applesText,
arg1: applesCount);

// Write("Press any key combination: ");
// ConsoleKeyInfo key = ReadKey();
// WriteLine();
// WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
// arg0: key.Key,
// arg1: key.KeyChar,
// arg2: key.Modifiers);

// WriteLine($"There are {args.Length} arguments.");


static void TimeTable(byte number)
{
	for (int i = 1; i <= 12; i++)
	{
		Console.WriteLine($"{number} x {i} = {number * i}");
	}
}

TimeTable(12);

class Person
{
	public DateTime BirthDate;
}
