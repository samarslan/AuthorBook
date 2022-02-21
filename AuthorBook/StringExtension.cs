using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorBook
{
    public class StringExtension
    { 
        public static string FirstLetterUpperCase(string word)
        {
            word = word.Trim();
            char firstLetter = word.ToCharArray()[0];
            word = word.Remove(0, 1);
            word = word.Insert(0, firstLetter.ToString().ToUpper());
            return word;
        }
    }
}
