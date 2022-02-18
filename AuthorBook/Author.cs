using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorBook
{
    internal class Author
    {
        private string _name;
        private string _surname;
        private DateTime _birthdate;
        private readonly int _age;
        private Sex _gender;
        private List<Book> _books;

        internal enum Sex
        {
            Male, Female, Other, Unkown
        }

        internal string Name { get => _name; set => _name = value.Trim(); }
        internal string Surname { get => _surname; set => _surname = value.ToUpper().Trim(); }
        internal DateTime Birthdate { get => _birthdate; set => _birthdate = value; }
        internal int Age { get => Birthdate.Year-DateTime.Now.Year;}
        internal List<Book> Books { get => _books; set => _books = value; }
        internal Sex Gender { get => _gender; set => _gender = value; }
        internal string FullName { get => Name + " " + Surname; }
    }
}
