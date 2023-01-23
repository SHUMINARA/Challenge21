using System;
using System.Runtime.CompilerServices;

string input;
Console.WriteLine("Please enter your number?");
input = Console.ReadLine();
char[] arrayOfDigits = input.ToArray();

List<char> digits = new List<char>();
digits.Add('0');
digits.Add('1');
digits.Add('2');
digits.Add('3');
digits.Add('4');
digits.Add('5');
digits.Add('6');
digits.Add('7');
digits.Add('8');
digits.Add('9');



Console.WriteLine("In your number you have:");

foreach (var number in digits)
{
    int count = 0;
    foreach (var digit in arrayOfDigits)
    {
        if(number == digit) count++;
    }
    Console.WriteLine(number + "=" + count);
}
