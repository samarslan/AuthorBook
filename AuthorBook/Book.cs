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
        private string name;
        private int pageNumber;
        private int volumes;
        private Genre genre;
        private Author author;
        private DateTime dateOfPublication;

        public string Name { get => name; set => name = value; }
        public int PageNumber { get => pageNumber; set => pageNumber = value; }
        public int Volumes { get => volumes; set => volumes = value; }
        public DateTime DateOfPublication { get => dateOfPublication; set => dateOfPublication = value; }
        internal Genre Genre1 { get => genre; set => genre = value; }
        internal Author Author
        {
            get => author;
            set
            {
                author = value;
                author.Books.Add(this);
            }
        }

        internal enum Genre
        {
            Fiction, Fantasy, Mystery, Thriller, Horror, Historical, Romance,
            [Description("Science Fiction")] ScienceFiction, [Description("Realist Literature")] RealistLiterature
        }
    }

}
