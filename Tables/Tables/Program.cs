using System;
using System.Runtime.CompilerServices;

string number;
Console.WriteLine("Please enter your number?");
number = Console.ReadLine();
char[] numberChar = number.ToArray();

List<char> numbers = new List<char>();
numbers.Add('0');
numbers.Add('1');
numbers.Add('2');
numbers.Add('3');
numbers.Add('4');
numbers.Add('5');
numbers.Add('6');
numbers.Add('7');
numbers.Add('8');
numbers.Add('9');



Console.WriteLine("In your number you have:");

foreach (var n in numbers)
{
    int count = 0;
    foreach (var numberChars in numberChar)
    {
        if(n == numberChars) count++;
    }
    Console.WriteLine(n + "=" + count);
}