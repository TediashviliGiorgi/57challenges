using Sol2;

string input;
do
{
    Console.WriteLine("Enter string");
    input = Console.ReadLine();
    if (string.IsNullOrEmpty(input))
    {
        Console.WriteLine("Please enter something");
    }
} while (string.IsNullOrEmpty(input));

var result = Solution.CountCharacters(input);
Console.WriteLine(result);