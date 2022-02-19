namespace AuthorBook
{
    internal class Author
    {
        private string _name;
        private string _surname;
        private DateTime _birthdate;
        private Sex _gender;
        private Book? _books;

        internal enum Sex
        {
            Male, Female, Other, Unkown
        }

        internal string Name { get => _name; set => _name = value.Trim(); }
        internal string Surname { get => _surname; set => _surname = value.ToUpper().Trim(); }
        internal DateTime Birthdate { get => _birthdate; set => _birthdate = value; }
        public int Age { get => Birthdate.Year - DateTime.Now.Year; }
        internal Book? Books { get => _books; set => _books = value; }
        internal Sex Gender { get => _gender; set => _gender = value; }
        public string FullName => _name + " " + _surname;
    }
}
