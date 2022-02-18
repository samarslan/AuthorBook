namespace AuthorBook
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.authorGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.authorCreatorButton = new System.Windows.Forms.Button();
            this.authorGenderComboBox = new System.Windows.Forms.ComboBox();
            this.authorBirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.authorSurnameTextBox = new System.Windows.Forms.TextBox();
            this.authorNameTextBox = new System.Windows.Forms.TextBox();
            this.bookGroupBox = new System.Windows.Forms.GroupBox();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.authorListBox = new System.Windows.Forms.ListBox();
            this.bookListBox = new System.Windows.Forms.ListBox();
            this.authorButton = new System.Windows.Forms.Button();
            this.bookButton = new System.Windows.Forms.Button();
            this.bookAuthorComboBox = new System.Windows.Forms.ComboBox();
            this.bookGenreComboBox = new System.Windows.Forms.ComboBox();
            this.bookDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.volumeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bookCreatorButton = new System.Windows.Forms.Button();
            this.authorGroupBox.SuspendLayout();
            this.bookGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // authorGroupBox
            // 
            this.authorGroupBox.Controls.Add(this.label4);
            this.authorGroupBox.Controls.Add(this.label3);
            this.authorGroupBox.Controls.Add(this.label2);
            this.authorGroupBox.Controls.Add(this.label1);
            this.authorGroupBox.Controls.Add(this.authorCreatorButton);
            this.authorGroupBox.Controls.Add(this.authorGenderComboBox);
            this.authorGroupBox.Controls.Add(this.authorBirthDatePicker);
            this.authorGroupBox.Controls.Add(this.authorSurnameTextBox);
            this.authorGroupBox.Controls.Add(this.authorNameTextBox);
            this.authorGroupBox.Location = new System.Drawing.Point(12, 12);
            this.authorGroupBox.Name = "authorGroupBox";
            this.authorGroupBox.Size = new System.Drawing.Size(400, 300);
            this.authorGroupBox.TabIndex = 0;
            this.authorGroupBox.TabStop = false;
            this.authorGroupBox.Text = "Create Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Birthdate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // authorCreatorButton
            // 
            this.authorCreatorButton.Location = new System.Drawing.Point(162, 236);
            this.authorCreatorButton.Name = "authorCreatorButton";
            this.authorCreatorButton.Size = new System.Drawing.Size(100, 50);
            this.authorCreatorButton.TabIndex = 4;
            this.authorCreatorButton.Text = "Create Author";
            this.authorCreatorButton.UseVisualStyleBackColor = true;
            // 
            // authorGenderComboBox
            // 
            this.authorGenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authorGenderComboBox.FormattingEnabled = true;
            this.authorGenderComboBox.Location = new System.Drawing.Point(113, 176);
            this.authorGenderComboBox.Name = "authorGenderComboBox";
            this.authorGenderComboBox.Size = new System.Drawing.Size(232, 27);
            this.authorGenderComboBox.TabIndex = 3;
            // 
            // authorBirthDatePicker
            // 
            this.authorBirthDatePicker.Location = new System.Drawing.Point(113, 131);
            this.authorBirthDatePicker.Name = "authorBirthDatePicker";
            this.authorBirthDatePicker.Size = new System.Drawing.Size(232, 26);
            this.authorBirthDatePicker.TabIndex = 2;
            // 
            // authorSurnameTextBox
            // 
            this.authorSurnameTextBox.Location = new System.Drawing.Point(113, 86);
            this.authorSurnameTextBox.Name = "authorSurnameTextBox";
            this.authorSurnameTextBox.Size = new System.Drawing.Size(232, 26);
            this.authorSurnameTextBox.TabIndex = 1;
            // 
            // authorNameTextBox
            // 
            this.authorNameTextBox.Location = new System.Drawing.Point(113, 41);
            this.authorNameTextBox.Name = "authorNameTextBox";
            this.authorNameTextBox.Size = new System.Drawing.Size(232, 26);
            this.authorNameTextBox.TabIndex = 0;
            // 
            // bookGroupBox
            // 
            this.bookGroupBox.Controls.Add(this.bookCreatorButton);
            this.bookGroupBox.Controls.Add(this.label10);
            this.bookGroupBox.Controls.Add(this.label9);
            this.bookGroupBox.Controls.Add(this.volumeNumericUpDown);
            this.bookGroupBox.Controls.Add(this.pageNumericUpDown);
            this.bookGroupBox.Controls.Add(this.label8);
            this.bookGroupBox.Controls.Add(this.label7);
            this.bookGroupBox.Controls.Add(this.label6);
            this.bookGroupBox.Controls.Add(this.label5);
            this.bookGroupBox.Controls.Add(this.bookDatePicker);
            this.bookGroupBox.Controls.Add(this.bookGenreComboBox);
            this.bookGroupBox.Controls.Add(this.bookAuthorComboBox);
            this.bookGroupBox.Controls.Add(this.bookNameTextBox);
            this.bookGroupBox.Location = new System.Drawing.Point(418, 12);
            this.bookGroupBox.Name = "bookGroupBox";
            this.bookGroupBox.Size = new System.Drawing.Size(434, 300);
            this.bookGroupBox.TabIndex = 1;
            this.bookGroupBox.TabStop = false;
            this.bookGroupBox.Text = "Create Book";
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(63, 41);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(189, 26);
            this.bookNameTextBox.TabIndex = 0;
            // 
            // authorListBox
            // 
            this.authorListBox.FormattingEnabled = true;
            this.authorListBox.ItemHeight = 19;
            this.authorListBox.Location = new System.Drawing.Point(12, 318);
            this.authorListBox.Name = "authorListBox";
            this.authorListBox.Size = new System.Drawing.Size(400, 137);
            this.authorListBox.TabIndex = 2;
            // 
            // bookListBox
            // 
            this.bookListBox.FormattingEnabled = true;
            this.bookListBox.ItemHeight = 19;
            this.bookListBox.Location = new System.Drawing.Point(418, 318);
            this.bookListBox.Name = "bookListBox";
            this.bookListBox.Size = new System.Drawing.Size(434, 137);
            this.bookListBox.TabIndex = 3;
            // 
            // authorButton
            // 
            this.authorButton.Location = new System.Drawing.Point(112, 461);
            this.authorButton.Name = "authorButton";
            this.authorButton.Size = new System.Drawing.Size(200, 50);
            this.authorButton.TabIndex = 4;
            this.authorButton.Text = "About Selected Author";
            this.authorButton.UseVisualStyleBackColor = true;
            // 
            // bookButton
            // 
            this.bookButton.Location = new System.Drawing.Point(535, 461);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(200, 50);
            this.bookButton.TabIndex = 5;
            this.bookButton.Text = "About Selected Book";
            this.bookButton.UseVisualStyleBackColor = true;
            // 
            // bookAuthorComboBox
            // 
            this.bookAuthorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookAuthorComboBox.FormattingEnabled = true;
            this.bookAuthorComboBox.Location = new System.Drawing.Point(63, 90);
            this.bookAuthorComboBox.Name = "bookAuthorComboBox";
            this.bookAuthorComboBox.Size = new System.Drawing.Size(189, 27);
            this.bookAuthorComboBox.TabIndex = 1;
            // 
            // bookGenreComboBox
            // 
            this.bookGenreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookGenreComboBox.FormattingEnabled = true;
            this.bookGenreComboBox.Location = new System.Drawing.Point(63, 131);
            this.bookGenreComboBox.Name = "bookGenreComboBox";
            this.bookGenreComboBox.Size = new System.Drawing.Size(189, 27);
            this.bookGenreComboBox.TabIndex = 2;
            // 
            // bookDatePicker
            // 
            this.bookDatePicker.Location = new System.Drawing.Point(63, 176);
            this.bookDatePicker.Name = "bookDatePicker";
            this.bookDatePicker.Size = new System.Drawing.Size(189, 26);
            this.bookDatePicker.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Author:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Genre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Date:";
            // 
            // pageNumericUpDown
            // 
            this.pageNumericUpDown.Location = new System.Drawing.Point(346, 41);
            this.pageNumericUpDown.Name = "pageNumericUpDown";
            this.pageNumericUpDown.Size = new System.Drawing.Size(74, 26);
            this.pageNumericUpDown.TabIndex = 8;
            // 
            // volumeNumericUpDown
            // 
            this.volumeNumericUpDown.Location = new System.Drawing.Point(346, 90);
            this.volumeNumericUpDown.Name = "volumeNumericUpDown";
            this.volumeNumericUpDown.Size = new System.Drawing.Size(74, 26);
            this.volumeNumericUpDown.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(278, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Pages:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(278, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 19);
            this.label10.TabIndex = 11;
            this.label10.Text = "Volumes:";
            // 
            // bookCreatorButton
            // 
            this.bookCreatorButton.Location = new System.Drawing.Point(164, 236);
            this.bookCreatorButton.Name = "bookCreatorButton";
            this.bookCreatorButton.Size = new System.Drawing.Size(100, 50);
            this.bookCreatorButton.TabIndex = 9;
            this.bookCreatorButton.Text = "Create Book";
            this.bookCreatorButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 521);
            this.Controls.Add(this.bookButton);
            this.Controls.Add(this.authorButton);
            this.Controls.Add(this.bookListBox);
            this.Controls.Add(this.authorListBox);
            this.Controls.Add(this.bookGroupBox);
            this.Controls.Add(this.authorGroupBox);
            this.Name = "Form1";
            this.Text = "Author Book";
            this.authorGroupBox.ResumeLayout(false);
            this.authorGroupBox.PerformLayout();
            this.bookGroupBox.ResumeLayout(false);
            this.bookGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox authorGroupBox;
        private GroupBox bookGroupBox;
        private ListBox authorListBox;
        private ListBox bookListBox;
        private Button authorButton;
        private Button bookButton;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button authorCreatorButton;
        private ComboBox authorGenderComboBox;
        private DateTimePicker authorBirthDatePicker;
        private TextBox authorSurnameTextBox;
        private TextBox authorNameTextBox;
        private TextBox bookNameTextBox;
        private Button bookCreatorButton;
        private Label label10;
        private Label label9;
        private NumericUpDown volumeNumericUpDown;
        private NumericUpDown pageNumericUpDown;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private DateTimePicker bookDatePicker;
        private ComboBox bookGenreComboBox;
        private ComboBox bookAuthorComboBox;
    }
}