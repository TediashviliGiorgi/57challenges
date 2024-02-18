using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol2
{
    public class Solution
    {
        public static string CalculateCharacters(string str)
        {

            while (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("Please type something...");
                str = Console.ReadLine();
            }
            

            return $"{str} has {str.Length} characters";
        }
    }
}
