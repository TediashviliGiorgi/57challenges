using Sol1;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;


string? name;

do
{
    Console.Write("What is your name: ");
    
    name = Console.ReadLine();

    if (string.IsNullOrEmpty(name))
    {
        Console.WriteLine("Please enter a name");
    }
    else
    {
        Console.WriteLine(Solution.DisplayGreeting(name));
    }
} while (string.IsNullOrEmpty(name));




