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
            this.bookGroupBox = new System.Windows.Forms.GroupBox();
            this.authorListBox = new System.Windows.Forms.ListBox();
            this.bookListBox = new System.Windows.Forms.ListBox();
            this.authorButton = new System.Windows.Forms.Button();
            this.bookButton = new System.Windows.Forms.Button();
            this.authorNameTextBox = new System.Windows.Forms.TextBox();
            this.authorSurnameTextBox = new System.Windows.Forms.TextBox();
            this.authorBirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.authorGenderComboBox = new System.Windows.Forms.ComboBox();
            this.authorCreatorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.authorGroupBox.SuspendLayout();
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
            // bookGroupBox
            // 
            this.bookGroupBox.Location = new System.Drawing.Point(418, 12);
            this.bookGroupBox.Name = "bookGroupBox";
            this.bookGroupBox.Size = new System.Drawing.Size(400, 300);
            this.bookGroupBox.TabIndex = 1;
            this.bookGroupBox.TabStop = false;
            this.bookGroupBox.Text = "Create Book";
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
            this.bookListBox.Size = new System.Drawing.Size(400, 137);
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
            this.bookButton.Location = new System.Drawing.Point(525, 461);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(200, 50);
            this.bookButton.TabIndex = 5;
            this.bookButton.Text = "About Selected Book";
            this.bookButton.UseVisualStyleBackColor = true;
            // 
            // authorNameTextBox
            // 
            this.authorNameTextBox.Location = new System.Drawing.Point(113, 41);
            this.authorNameTextBox.Name = "authorNameTextBox";
            this.authorNameTextBox.Size = new System.Drawing.Size(232, 26);
            this.authorNameTextBox.TabIndex = 0;
            // 
            // authorSurnameTextBox
            // 
            this.authorSurnameTextBox.Location = new System.Drawing.Point(113, 86);
            this.authorSurnameTextBox.Name = "authorSurnameTextBox";
            this.authorSurnameTextBox.Size = new System.Drawing.Size(232, 26);
            this.authorSurnameTextBox.TabIndex = 1;
            // 
            // authorBirthDatePicker
            // 
            this.authorBirthDatePicker.Location = new System.Drawing.Point(113, 131);
            this.authorBirthDatePicker.Name = "authorBirthDatePicker";
            this.authorBirthDatePicker.Size = new System.Drawing.Size(232, 26);
            this.authorBirthDatePicker.TabIndex = 2;
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
            // authorCreatorButton
            // 
            this.authorCreatorButton.Location = new System.Drawing.Point(179, 236);
            this.authorCreatorButton.Name = "authorCreatorButton";
            this.authorCreatorButton.Size = new System.Drawing.Size(100, 50);
            this.authorCreatorButton.TabIndex = 4;
            this.authorCreatorButton.Text = "Create Author";
            this.authorCreatorButton.UseVisualStyleBackColor = true;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Surname:";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gender:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 521);
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
    }
}