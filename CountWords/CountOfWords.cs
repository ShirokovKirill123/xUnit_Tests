using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CountWords
{
    public class CountOfWords
    {
        public int CountWords(string input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));

            // Удаление лишних символов
            string sanitizedInput = Regex.Replace(input, @"[^\w\s-]", "").Trim();

            // Разбиение строки на слова
            return sanitizedInput.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
