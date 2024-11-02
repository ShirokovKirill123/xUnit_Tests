using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainsSubstring
{
    public class ContSubstring
    {
        public bool ContainsSubstring(string input, string substring, bool ignoreCase = false, bool ignoreWhitespace = false)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));
            if (substring == null) throw new ArgumentNullException(nameof(substring));

            if (ignoreWhitespace)
            {
                input = input.Replace(" ", "").Replace("\t", "");
                substring = substring.Replace(" ", "").Replace("\t", "");
            }

            if (ignoreCase)
            {
                input = input.ToLower();
                substring = substring.ToLower();
            }

            return input.Contains(substring);
        }
    }
}
