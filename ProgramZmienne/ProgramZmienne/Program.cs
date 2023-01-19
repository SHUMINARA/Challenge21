using System;
string name, ageString, genderString;
int age;
Console.WriteLine("Please enter your name?");
name = Console.ReadLine();
bool ewa = name == "ewa";
Console.WriteLine("Please enter your age?");
ageString = Console.ReadLine();
age = int.Parse(ageString);
Console.WriteLine("Please enter your gender (m/f)?");
genderString = Console.ReadLine();
bool woman = genderString == "f";

if (age < 30 && woman)
{
    Console.WriteLine("\nYou are woman under 30 years old.");
}
else if (ewa && age is 33)
{
    Console.WriteLine("\nYou are Ewa and you are 33 years old.");
}
else if (!woman && age < 18)
{
    Console.WriteLine("\nYou are underage man.");
}
else
{ Console.WriteLine("\nI have no idea who are you :)"); }
