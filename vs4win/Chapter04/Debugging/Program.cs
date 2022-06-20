using static System.Console;
using System.Diagnostics;
static double Add(double a, double b)
{
	return a + b; // deliberate bug!
}

double a = 4.5;
double b = 2.5;
double answer = Add(a, b);
WriteLine($"{a} + {b} = {answer}");
ReadLine(); // wait for user to press ENTER

Debug.WriteLine("I AM WATCHING!");
Trace.WriteLine("Trace says, I am watching!");