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
            {
                authorGenderComboBox.DataSource = Enum.GetValues(typeof(Author.Sex));
                authorGenderComboBox.SelectedIndex = 3;

                bookGenreComboBox.DisplayMember = "Value";
                bookGenreComboBox.ValueMember = "Key";
                bookGenreComboBox.DataSource = EnumList.Of<Book.Genre>();
            }
        }

        private void authorCreatorButton_Click(object sender, EventArgs e)
        {
            var isThereWriter = authorList.Find(x => x.Name == FirstLetterUpperCase(authorNameTextBox.Text) && x.Surname == authorSurnameTextBox.Text.ToUpper());

            if (isThereWriter == null)
            {
                if (authorNameTextBox.Text.Length >= 1 && authorSurnameTextBox.Text.Length >= 1)
                {
                    if (authorBirthDatePicker.Value <= DateTime.Now)
                    {
                        Author author = new Author()
                        {
                            Name = FirstLetterUpperCase(authorNameTextBox.Text),
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

        public string FirstLetterUpperCase(string word)
        {
            word = word.Trim();
            char firstLetter = word.ToCharArray()[0];
            word = word.Remove(0, 1);
            word = word.Insert(0, firstLetter.ToString().ToUpper());
            return word;
        }

        private void bookCreatorButton_Click(object sender, EventArgs e)
        {
            var isThereBook = books.Find(x => x.Name == bookNameTextBox.Text);

            if (isThereBook == null)
            {
                if (bookNameTextBox.Text.Length >= 1)
                {
                    if (pageNumericUpDown.Value > 0)
                    {
                        if (volumeNumericUpDown.Value > 0)
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
                                            Genre1 = (Book.Genre)bookGenreComboBox.SelectedItem,
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
                            MessageBox.Show("Please enter a valid volume number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid page number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            bookListBox.DataSource = books;
            bookListBox.DisplayMember = "Name";
        }
    }
}