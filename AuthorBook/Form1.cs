namespace AuthorBook
{
    public partial class Form1 : Form
    {
        List<Author> authorList;
        List<Book> books;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                authorGenderComboBox.Items.Add(Author.Gender.Male);
                authorGenderComboBox.Items.Add(Author.Gender.Female);
                authorGenderComboBox.Items.Add(Author.Gender.Other);
                authorGenderComboBox.Items.Add(Author.Gender.Unkown);
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
            Author isThereWriter = authorList.Find(x => x.Name == FirstLetterUpperCase(authorNameTextBox.Text) && x.Surname == authorSurnameTextBox.Text.ToUpper());
        
            if(isThereWriter==null)
            {
                if(authorNameTextBox.Text.Length>=1 && authorSurnameTextBox.Text.Length>=1)
                {
                    if (authorBirthDatePicker.Value <= DateTime.Now)
                    {
                        Author author = new Author()
                        {
                            Name = authorNameTextBox.Text,
                            Surname = authorSurnameTextBox.Text,
                            Birthdate = authorBirthDatePicker.Value,
                            Gender1 = (Author.Gender)authorGenderComboBox.SelectedItem
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

            authorListBox.DataSource = authorList;
            authorListBox.DisplayMember = "FullName";

            bookAuthorComboBox.DataSource = authorList;
            bookAuthorComboBox.DisplayMember = "FullName";
        }

        public string FirstLetterUpperCase(string word)
        {
            word = word.Trim();
            char firstLetter = word.ToCharArray()[0];
            word=word.Remove(0, 1);
            word = word.Insert(0, firstLetter.ToString().ToUpper());
            return word;
        }
    }
}