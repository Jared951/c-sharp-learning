/* 
dotnet new console: type this in terminal for new project
dotnet run: to run application
*/

Console.WriteLine("Hello, World!"); // to write on to a new line
Console.Write("Hello WORLD"); // to write on the current line

/* 
Character Literal:
single quotes around a single character creates a character literal, 
if you wanted to display one single character
*/
Console.WriteLine('b'); 

/*
Integer Literal 
This is how to print integers to the console
*/
Console.WriteLine(123); 

/*
Floating Point Literal 
This is how to print numbers with decimals
Float Type    Precision
----------------------------
float         ~6-9 digits
double        ~15-17 digits
decimal        28-29 digits
*/
Console.WriteLine(0.25F); //F added at the end is a Literal Suffix, it tells the compilier we want to to work with a float
Console.WriteLine(2.625); //Double Suffix, compilier defaults to double suffix if there is no literal suffix
Console.WriteLine(12.39816m); //the literal suffix m or M tells the compiler we want to work with a decimal

/*
Boolean Literal 
This is how to print boolean to the console
*/
Console.WriteLine(true);
Console.WriteLine(false);

/*
Assigning a variable 
declare what data type the variable will be -> 
set what the variable is equal to -> 
print it in the console

a variable of type string to hold the name "Bob".
a variable of type int to store a number
a variable of type decimal, float, or double to store decimals.
*/
string firstName;
firstName = "Bob";
Console.WriteLine(firstName);

string firstNameTwo = "Chuck";
Console.WriteLine(firstNameTwo);

string name = "Bob";
int messages = 3;
decimal temperature = 34.4m;

Console.Write("Hello, ");
Console.Write(name);
Console.Write("! You have ");
Console.Write(messages);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(temperature);
Console.Write(" celsius.");

/*
Reassign the value of a variable
You can reuse and reassign the variable as many times as you want. This example illustrates that idea.
This will print all over their names
*/
string personName;
personName = "Bob";
Console.WriteLine(personName);
personName = "Liem";
Console.WriteLine(personName);
personName = "Isabella";
Console.WriteLine(personName);
personName = "Yasmin";
Console.WriteLine(personName);

/*
Implicitly Typed Local Variables
The var keyword tells the compiler to infer the data type of the variable based on the value it is initialized to.
*/
var message = "Hello world!";
Console.WriteLine(message);

Console.WriteLine("Hello\nWorld!"); // New line
Console.WriteLine("Hello\tWorld!"); // Tabs
Console.WriteLine("Hello \"World\"!"); // prints: Hello "World"! ---- \" this is for adding quotes to a string
Console.WriteLine("c:\\source\\repos"); // prints: c:\source\repos ---- use \\ when a single \ is need in a string

// Example
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

/* 
Verbatim string literal

A verbatim string literal will keep all whitespace and characters without the need to escape the backslash. 
To create a verbatim string, use the @ directive before the literal string.
*/
Console.Write(@"c:\invoices");

/*
Recap 

Use character escape sequences when you need to insert a special character into a literal string, like a tab \t, new line \n, or a double quotation mark \".
Use an escape character for the backslash \\ when you need to use a backslash in all other scenarios.
Use the @ directive to create a verbatim string literal that keeps all whitespace formatting and backslash characters in a string.
Use the \u plus a four-character code to represent Unicode characters (UTF-16) in a string.
Unicode characters may not print correctly depending on the application.
*/







// Concatenate a literal string and a variable
string personFirstName = "Bob";
string personMessage = "Hello " + personFirstName;
Console.WriteLine(personMessage);

/* 
Recap

String concatenation allows you to combine smaller literal and variable strings into a single string.
Avoid creating intermediate variables if adding them doesn't increase readability.
*/







// Exercise - Combine strings using string interpolation

int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}!");

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

/*
Recap

String interpolation provides an improvement over string concatenation by reducing the number of characters required in some situations.
You can combine string interpolation and verbatim literals by combining the symbols for each and using that as a prefix for the string template.
*/







// Exercise - Perform addition with implicit data conversion

int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

string theFirstName = "Bob";
int widgetSold = 7;
Console.WriteLine(theFirstName + " sold " + widgetSold + " widgets.");

string veryFirstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(veryFirstName + " sold " + (widgetsSold + 7) + " widgets."); // with parenthese around the two it will add the numbers together instead of concating them as a string, result 14

/*
You can perform mathematical-like addition operations on numbers.
Both string concatenation and addition use the plus + symbol. This is called overloading an operator, and the compiler infers the proper use based on the data types it's operating on.
When it can, the C# compiler will implicitly convert an int into a string if it's obvious that the developer is trying to concatenate the string representation of a number for presentation purposes.
Use parentheses to define an order of operations to explicitly tell the compiler that you want to perform certain operations before other operations.
*/







// Perform Math Operations

int sum = 7 + 5;
int difference = 7 - 5;
int product =  7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");

int first = 7;
int second = 5;
decimal quotientTwo = (decimal)first / (decimal)second;
Console.WriteLine(quotientTwo);

Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

/*
In math, PEMDAS is an acronym that helps students remember the order of operations. The order is:

Parentheses (whatever is inside the parenthesis is performed first)
Exponents
Multiplication and Division (from left to right)
Addition and Subtraction (from left to right)

C# follows the same order as PEMDAS except for exponents. While there's no exponent operator in C#, you can use the System.Math.Pow method. 
The module "Call methods from the .NET Class Library using C#" will feature this method and others.
*/

int value1 = 3 + 4 * 5; // 23
int value2 = (3 + 4) * 5; // 35
Console.WriteLine(value1); 
Console.WriteLine(value2); 

/*
Recap 

Use operators like +, -, *, and / to perform basic mathematical operations.
The division of two int values will result in the truncation of any values after the decimal point. 
To retain values after the decimal point, you need to cast the divisor or dividend (or both) from int into a floating point number like decimal first, then the quotient must be of the same floating point type as well in order to avoid truncation.
Perform a cast operation to temporarily treat a value as if it were a different data type.
Use the % operator to capture the remainder after division.
The order of operations will follow the rules of the acronym PEMDAS.
*/







// Increment and decrement

// compound assignment operators
// +=
int value = 0;     // value is now 0.
value = value + 5; // value is now 5.
value += 5;        // value is now 10.

// ++
int value = 0;     // value is now 0.
value = value + 1; // value is now 1.
value++;           // value is now 2.

int value = 1;
value++;
Console.WriteLine("First: " + value); // First: 2
Console.WriteLine($"Second: {value++}"); // Second: 2
Console.WriteLine("Third: " + value); // Third: 3
Console.WriteLine("Fourth: " + (++value)); // Fourth: 4

/*
Recap

Use compound assignment operators like +=, -=, *=, ++, and -- to perform a mathematical operation like increment or decrement, 
then assign the result into the original variable.
Increment and decrement operators perform differently depending on whether the operator is before or after the operand.

*/








