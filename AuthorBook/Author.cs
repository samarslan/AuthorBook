using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorBook
{
    internal class Author
    {
        private string firstName;
        private string lastName;
        private DateTime birthdate;
        private int age;
        private Gender gender;
        private List<Book> books;

        internal enum Gender
        {
            Male, Female, Other, Unkown
        }

        internal string FirstName { get => firstName; set => firstName = value.Trim(); }
        internal string LastName { get => lastName; set => lastName = value.ToUpper().Trim(); }
        internal DateTime Birthdate { get => birthdate; set => birthdate = value; }
        internal int Age { get => age; set => age = value; }
        internal List<Book> Books { get => books; set => books = value; }
        internal  Gender Gender1 { get => gender; set => gender = value; }
        internal string FullName { get => FirstName + " " + LastName; }
    }
}
