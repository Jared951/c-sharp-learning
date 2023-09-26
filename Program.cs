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