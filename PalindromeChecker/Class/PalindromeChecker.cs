using PalindromeChecker.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChecker.Class
{
    public class PalindromeChecker : IPalindromeChecker
    {
        public bool IsPalindrome(string text)
        {
            var lowerCase = text.ToLower();
            var trimSpace = lowerCase.Replace(" ", string.Empty);

            var textArray = trimSpace.ToCharArray();
            var reverse = textArray.Reverse();

            if (trimSpace.Equals(reverse))
                return true;

            return false;
        }
    }
}
