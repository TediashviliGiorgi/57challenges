//first version

//static string GetString(string quote, string author)
//{
//    if (!string.IsNullOrEmpty(quote) || !string.IsNullOrEmpty(author))
//    {
//        return $"{author} says, {quote}.";
//    }
//    return "invalid input";
//}

//Console.WriteLine("What is the quote?: ");
//string quote = Console.ReadLine();

//Console.WriteLine("Who said it?: ");
//string author = Console.ReadLine();


//string result = GetString(quote, author);

//Console.WriteLine(result);
//Console.ReadKey();


//challenge

List<Dictionary<string, string>> quotesWithAuthor = new List<Dictionary<string, string>>();

bool work;
do
{
    work = true;


    Console.WriteLine("choose operation: add, seeList or exit: ");
    string operation = Console.ReadLine();

    if(operation == "exit")
    {
        work = false;
        
    }
    else if (operation == "add")
    {
        
        Console.WriteLine("What is the quote?: ");
        string quote = Console.ReadLine();

        Console.WriteLine("Who said it?: ");
        string author = Console.ReadLine();

        if (!string.IsNullOrEmpty(quote) || !string.IsNullOrEmpty(author))
        {
            Dictionary<string, string> quote1 = new Dictionary<string, string>();
            quote1.Add(author, quote);

            quotesWithAuthor.Add(quote1);
        }
    }else if (operation == "seeList")
    {
        foreach (var quoteDict in quotesWithAuthor)
        {
            foreach (var kvp in quoteDict)
            {
                Console.WriteLine($"{kvp.Key} says, {kvp.Value}.");
            }
        }
    }

} while (work == true);






