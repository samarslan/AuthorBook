using System.ComponentModel;

namespace AuthorBook
{
    internal class Book
    {
        private string _name;
        private int _pageNumber;
        private int _volumes;
        private Genre _genre;
        private Author _author;
        private DateTime _dateOfPublication;

        public string Name { get => _name; set => _name = value; }
        public int PageNumber { get => _pageNumber; set => _pageNumber = value; }
        public int Volumes { get => _volumes; set => _volumes = value; }
        public DateTime DateOfPublication { get => _dateOfPublication; set => _dateOfPublication = value; }
        internal Genre Genre1 { get => _genre; set => _genre = value; }
        internal Author Author
        {
            get => _author;
            set
            {
                _author = value;
                _author.Books = this;
            }
        }

        internal enum Genre
        {
            Fiction, Fantasy, Mystery, Thriller, Horror, Historical, Romance,
            [Description("Science Fiction")] ScienceFiction, [Description("Realist Literature")] RealistLiterature
        }

        public static IEnumerable<KeyValuePair<Book.Genre, string>> GetGenrePairs()
        {
            return Enum.GetValues(typeof(Book.Genre))
                .Cast<Book.Genre>()
                .Select(p => new KeyValuePair<Book.Genre, string>(
                    p,
                    (p.GetType().GetField(p.ToString())
                        .GetCustomAttributes(typeof(DescriptionAttribute), false)
                        .FirstOrDefault() as DescriptionAttribute)?.Description ?? p.ToString()
                ))
                .ToList();
        }
    }

}
