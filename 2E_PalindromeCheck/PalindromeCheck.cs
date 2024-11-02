using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2E_PalindromeCheck
{
    public class PalindromeCheck
    {
        public bool IsPalindrome(string input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));
            string reversed = new string(input.ToCharArray().Reverse().ToArray());
            return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }
    }
}
