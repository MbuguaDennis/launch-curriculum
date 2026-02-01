// Data types
// Text
using System.Security;

string firstName = "Dennis";
 char firstNameLetter = firstName[0];

 int salary = 300000;

string profession = "Software Engineering";

Console.WriteLine(firstName);
Console.WriteLine(salary);
Console.WriteLine(profession);
Console.WriteLine(firstNameLetter);


Console.WriteLine($"My name is {firstName}, I work in {profession} and my salary is {salary}");


string dayOfWeek = "Sunday";
bool isAtHome = true;

if (dayOfWeek == "Sunday" && isAtHome)

{
   Console.WriteLine($"Hey {firstName} today is {dayOfWeek} and you can code from home {isAtHome}"); 
}