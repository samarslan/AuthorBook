namespace AuthorBook
{
    public partial class Form1 : Form
    {
        List<Author> authorList = new List<Author>();
        List<Book> books = new List<Book>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            authorGenderComboBox.DataSource = Enum.GetValues(typeof(Author.Sex));
            authorGenderComboBox.SelectedIndex = 3;

            bookGenreComboBox.DataSource = Book.GetGenrePairs();
            bookGenreComboBox.DisplayMember = "Value";
            bookGenreComboBox.ValueMember = "Key";
        }

        private void authorCreatorButton_Click(object sender, EventArgs e)
        {
            var isThereWriter = authorList.Find(x => x.Name == StringExtension.FirstLetterUpperCase(authorNameTextBox.Text) && x.Surname == authorSurnameTextBox.Text.ToUpper());

            if (isThereWriter == null)
            {
                if (authorNameTextBox.Text.Length >= 1 && authorSurnameTextBox.Text.Length >= 1)
                {
                    if (authorBirthDatePicker.Value <= DateTime.Now)
                    {
                        Author author = new Author()
                        {
                            Name = authorNameTextBox.Text,
                            Surname = authorSurnameTextBox.Text,
                            Birthdate = authorBirthDatePicker.Value,
                            Gender = (Author.Sex)authorGenderComboBox.SelectedItem
                        };
                        authorList.Add(author);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid birthday.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid name and surname.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("An author with same name already exits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            authorListBox.DataSource = authorList.ToList();
            authorListBox.DisplayMember = "FullName";

            bookAuthorComboBox.DataSource = authorList.ToList();
            bookAuthorComboBox.DisplayMember = "FullName";
        }

        private void bookCreatorButton_Click(object sender, EventArgs e)
        {
            var isThereBook = books.Find(x => x.Name == bookNameTextBox.Text);

            if (isThereBook == null)
            {
                if (bookNameTextBox.Text.Length >= 1)
                {
                    if (bookAuthorComboBox != null)
                    {
                        if (bookGenreComboBox != null)
                        {
                            if (bookDatePicker.Value <= DateTime.Now)
                            {
                                Book book = new Book()
                                {
                                    Name = bookNameTextBox.Text,
                                    Author = (Author)bookAuthorComboBox.SelectedItem,
                                    Genre1 = (Book.Genre)bookGenreComboBox.SelectedValue,
                                    PageNumber = (int)pageNumericUpDown.Value,
                                    Volumes = (int)volumeNumericUpDown.Value,
                                    DateOfPublication = bookDatePicker.Value
                                };
                                books.Add(book);
                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid publish date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please choose a genre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please choose an author.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid book name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("A book with same name already exits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bookListBox.DataSource = books.ToList();
            bookListBox.DisplayMember = "Name";
        }

        private void authorButton_Click(object sender, EventArgs e)
        {
            Author author = (Author)authorListBox.SelectedItem;
            bool? doesAuthorHasBook = null;

            string? authorsBooks = null;
            foreach (Book x in books)
            {
                if (x.Author == author)
                {
                    authorsBooks += x.Name + ",";
                }
                else
                {
                    doesAuthorHasBook = false;
                }
            }
            int bookCount = authorsBooks.Split(',').Length;


            if (doesAuthorHasBook==false)
            {
                MessageBox.Show(author.FullName + " doesn't have any books");
            }
            else if (bookCount > 2)
            {
                MessageBox.Show(author.FullName + " has books named " + authorsBooks.TrimEnd(' ', ','));
            }
            else
            {
                MessageBox.Show(author.FullName + " has a book named " + authorsBooks.TrimEnd(' ', ','));
            }
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            Book b = (Book)bookListBox.SelectedItem;
            MessageBox.Show("About "+b.Name+" named book:\nAuthor: "+b.Author.FullName+"\n"+b.PageNumber+" Pages\nGenre: "+Book.GetGenrePairs().ElementAt((int) b.Genre1).Value+"\nDate of Publish: "+ b.DateOfPublication.ToShortDateString());
        }
    }
}