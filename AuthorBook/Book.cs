using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                _author.Books.Add(this);
            }
        }

        internal enum Genre
        {
            Fiction, Fantasy, Mystery, Thriller, Horror, Historical, Romance,
            [Description("Science Fiction")] ScienceFiction, [Description("Realist Literature")] RealistLiterature
        }
    }

}
