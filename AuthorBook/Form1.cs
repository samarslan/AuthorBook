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
                authorGenderComboBox.Items.Add(Author.Sex.Male);
                authorGenderComboBox.Items.Add(Author.Sex.Female);
                authorGenderComboBox.Items.Add(Author.Sex.Other);
                authorGenderComboBox.Items.Add(Author.Sex.Unkown);
                authorGenderComboBox.SelectedIndex = 3;

                bookGenreComboBox.Items.Add(Book.Genre.Fiction);
                bookGenreComboBox.Items.Add(Book.Genre.Fantasy);
                bookGenreComboBox.Items.Add(Book.Genre.Mystery);
                bookGenreComboBox.Items.Add(Book.Genre.Thriller);
                bookGenreComboBox.Items.Add(Book.Genre.Horror);
                bookGenreComboBox.Items.Add(Book.Genre.Historical);
                bookGenreComboBox.Items.Add(Book.Genre.Romance);
                bookGenreComboBox.Items.Add(Book.Genre.ScienceFiction);
                bookGenreComboBox.Items.Add(Book.Genre.RealistLiterature);
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
                        MessageBox.Show("Please enter a valid birthday.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid name and surname.");
                }
            }
            else
            {
                MessageBox.Show("An author with same name already exits.");
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
    }
}