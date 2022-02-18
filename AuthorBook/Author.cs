using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorBook
{
    internal class Author
    {
        private string name;
        private string surname;
        private DateTime birthdate;
        private int age;
        private Gender gender;
        private List<Book> books;

        internal enum Gender
        {
            Male, Female, Other, Unkown
        }

        internal string Name { get => name; set => name = value.Trim(); }
        internal string Surname { get => surname; set => surname = value.ToUpper().Trim(); }
        internal DateTime Birthdate { get => birthdate; set => birthdate = value; }
        internal int Age { get => Birthdate.Year-DateTime.Now.Year;}
        internal List<Book> Books { get => books; set => books = value; }
        internal  Gender Gender1 { get => gender; set => gender = value; }
        internal string FullName { get => Name + " " + Surname; }
    }
}
