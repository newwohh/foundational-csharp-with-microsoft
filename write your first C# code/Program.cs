Console.WriteLine("Hello, World!");
Console.WriteLine("This is the first line.");
Console.WriteLine("This is the second line.");
Console.WriteLine("This is the first line.");

Console.Write("This is ");
Console.Write("the second ");
Console.Write("line.");

Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("Hello \"World\"!");

Console.WriteLine("@   /bin/bash (code goes here) ");

string firstname = "Bob";
string message = "Hello " + firstname;
string greeting = "Hello";
string message2 = $"{greeting} {firstname}";
Console.WriteLine(message2);
Console.WriteLine(greeting + " " + firstname);

int result = 3 + 1 * 5 / 2;
Console.WriteLine(result);

// int sophiaSum;
// Console.WriteLine("Sophia: " + sophiaSum);


string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

string englishOutput = $"View English output:\n\t @c:\\Exercise\\{projectName}\\data.txt";
Console.WriteLine(englishOutput);

string russianOutput =  $"{russianMessage}\n\t c:\\Exercise\\{projectName}\\ru-RU\\data.txt";
Console.WriteLine(russianOutput);

int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);