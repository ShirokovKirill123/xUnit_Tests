using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __3E_LinelengthCheck
{
    public class LineLength
    {
        public int GetStringLength(string input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));
            return input.Length;
        }
    }
}
