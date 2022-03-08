// See https://aka.ms/new-console-template for more information
using _15_CSharpVersions;

Console.WriteLine("------------NAMED ARGUMENTS--------------------");
 Utility.NamedArgumentsTask();

Console.WriteLine("------------Optional ARGUMENTS--------------------");
Utility.OptionalArgumentsTask();

Console.WriteLine("------------Dynamic Example--------------------");
Utility.dynamicExample();
dynamic d = 1;
var testSum = d + 3;
// Rest the mouse pointer over testSum in the following statement.
System.Console.WriteLine(testSum);
//Conversion of dynamic
dynamic d1 = 7;
dynamic d2 = "a string";
dynamic d3 = System.DateTime.Today;
dynamic d4 = System.Diagnostics.Process.GetProcesses();
//----------------
int i = d1;
string str = d2;
DateTime dt = d3;
System.Diagnostics.Process[] procs = d4;

Console.WriteLine("------------Autoprop Example--------------------");
AutoPropEx cust1 = new AutoPropEx(4987.63, "Northwind", 90108);

// Modify a property.
cust1.TotalPurchases += 499.99;

//----------------EXPRESSION BODY MEMBERS--------------------------
Person p = new Person("Mandy", "Dejesus");
Console.WriteLine(p);
p.DisplayName();

//---------------------String Interpolation------------------------
double a = 3;
double b = 4;
Console.WriteLine($"Area of the right triangle with legs of {a} and {b} is {0.5 * a * b}");
Console.WriteLine($"Length of the hypotenuse of the right triangle with legs of {a} and {b} is {CalculateHypotenuse(a, b)}");

double CalculateHypotenuse(double leg1, double leg2) => Math.Sqrt(leg1 * leg1 + leg2 * leg2);

// Expected output:
// Area of the right triangle with legs of 3 and 4 is 6
// Length of the hypotenuse of the right triangle with legs of 3 and 4 is 5


//---------------------Name Of --------------------------------------
Console.WriteLine(nameof(System.Collections.Generic));  // output: Generic
Console.WriteLine(nameof(List<int>));  // output: List
Console.WriteLine(nameof(List<int>.Count));  // output: Count
Console.WriteLine(nameof(List<int>.Add));  // output: Add

var numbers = new List<int> { 1, 2, 3 };
Console.WriteLine(nameof(numbers));  // output: numbers
Console.WriteLine(nameof(numbers.Count));  // output: Count
Console.WriteLine(nameof(numbers.Add));  // output: Add

var @new = 5;
Console.WriteLine(nameof(@new));  // output: new