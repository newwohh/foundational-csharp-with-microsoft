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




string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

string englishOutput = $"View English output:\n\t @c:\\Exercise\\{projectName}\\data.txt";
Console.WriteLine(englishOutput);

string russianOutput =  $"{russianMessage}\n\t c:\\Exercise\\{projectName}\\ru-RU\\data.txt";
Console.WriteLine(russianOutput);

int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");

int first = 7;
int second = 5;

decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);

int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

int fahrenheit = 94;
decimal celsius = ((decimal) fahrenheit - 32) * 5 / 9;
Console.WriteLine($"The temperature is {celsius} Celsius.");
Console.WriteLine("Windows "+ 11 );

// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

int sophiaSum = (sophia1 + sophia2 + sophia3 + sophia4 + sophia5 / currentAssignments);
int nicolasSum = (nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5 / currentAssignments);
int zahirahSum = (zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5 /currentAssignments);
int jeongSum = (jeong1 + jeong2 + jeong3 + jeong4 + jeong5 / currentAssignments);

Console.WriteLine("Sophia: " + sophiaSum);
Console.WriteLine("Nicolas: " + nicolasSum);
Console.WriteLine("Zahirah: " + zahirahSum);
Console.WriteLine("Jeong: " + jeongSum);

decimal nicolasScore = nicolasSum / currentAssignments;
decimal zahirahScore = zahirahSum / currentAssignments;
decimal jeongScore = jeongSum / currentAssignments;
decimal sophiaScore = sophiaSum / currentAssignments;

Console.WriteLine("Sophia: " + sophiaScore + " A");
Console.WriteLine("Nicolas: " + nicolasScore + " B");
Console.WriteLine("Zahirah: " + zahirahScore + " B");
Console.WriteLine("Jeong: " + jeongScore + " A");

// var value = (int) dividend / (int) divisor;

// int sophiaSum;
// Console.WriteLine("Sophia: " + sophiaSum);

string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

Console.WriteLine($"{course1Name} {course1Grade}");
Console.WriteLine($"{course2Name} {course2Grade}");
Console.WriteLine($"{course3Name} {course3Grade}");
Console.WriteLine($"{course4Name} {course4Grade}");
Console.WriteLine($"{course5Name} {course5Grade}");

Console.WriteLine($"{course1Name} {course1Grade} {course1Credit}");
Console.WriteLine($"{course2Name} {course2Grade} {course2Credit}");
Console.WriteLine($"{course3Name} {course3Grade} {course3Credit}");
Console.WriteLine($"{course4Name} {course4Grade} {course4Credit}");
Console.WriteLine($"{course5Name} {course5Grade} {course5Credit}");


int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

int totalGradePoints = 0;
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

decimal gradePointAverage = (decimal) totalGradePoints/totalCreditHours;

int leadingDigit = (int) gradePointAverage;
int trailingDigits = (int) (gradePointAverage * 100) - (leadingDigit * 100);

Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");

Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");

Console.WriteLine($"\nFinal GPA:\t\t\t{leadingDigit}.{trailingDigits}");

Console.WriteLine(7/5);

string name = "Bob";
int messages = 3;
decimal celsius2 = 34.4m;

Console.WriteLine($"Hello, {name}! You have {messages} in your inbox. The temperature is {celsius2} celsius.");