using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol2
{
    public class Solution
    {
        public static int CountCharacters(string str)
        {
            string newString = str.Replace(" ", "");
            
            return newString.Length;
        }
    }
}
