// 10.1. Перевiрити ім’я та прізвище.

/* Console.WriteLine("Please enter your name and surname (including space between them): ");
string input = Console.ReadLine();
string[] pieces = input.Split(' ');
if (pieces.Length < 2)
{
    Console.WriteLine("Please enter your name and surname including space between them");
}
else
{
    string firstName = pieces[0];
    string lastName = pieces[1];
    if (char.ToLower(firstName[0]) == char.ToLower(lastName[0]))
    {
        Console.WriteLine("The Surname begins with the same letter as the first name");
    }
    else
    {
        Console.WriteLine("The Surname does not begin with the same letter as the first name.");
    }
}*/

// 10.2. Видалення пробілiв.
/*string report = "My planner for the tomorrow\n";
report += $"Exact time and date when the plans were written: {DateTime.Now}\n";
report += "The list of pans for tomorrow:\n";
while (true)
{
    Console.WriteLine("Please enter your plans for tomorrowor 'end' to finish): ");
    string input = Console.ReadLine();
    if (input.ToLower() == "end")
        break;
    report += $"- {input}\n";
}
Console.WriteLine("\nYour list of plans for tomorrow: ");
Console.WriteLine(report);*/

// _UPDATED VERSION!_ 10.2. Видалення пробілiв.
using System;
using System.Text; // StringBuilder did not work without this line. As I understood the problem appears when the compiler is not given a hint, so it is not able to find the correct place from where to take this action/class.
StringBuilder report = new StringBuilder();
// report.AppendLine($"Exact time and date when the plans were written: {DateTime.Now}");
while (true)
{
    Console.WriteLine("Please enter your plans for tomorrow (or 'end' to finish): ");
    string input = Console.ReadLine();
    if (input.ToLower() == "end")
        break;
    report.AppendLine($"- {input}");
}
Console.WriteLine("\nThe list of plans for tomorrow:");
report.AppendLine($"Exact time and date when the plans were written: {DateTime.Now}");
Console.WriteLine(report.ToString());
// 10.3. Видалення пробілiв.

/*Console.WriteLine("Please enter the line with words and devide them by comma: ");
string input = Console.ReadLine();
string result = input.Replace(" ", "");
Console.WriteLine("The result is the next: ");
Console.WriteLine(result);*/
