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
            this.SuspendLayout();
            // 
            // authorGroupBox
            // 
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
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox authorGroupBox;
        private GroupBox bookGroupBox;
        private ListBox authorListBox;
        private ListBox bookListBox;
        private Button authorButton;
        private Button bookButton;
    }
}