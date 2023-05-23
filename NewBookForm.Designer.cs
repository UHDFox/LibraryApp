namespace LibraryApp
{
    partial class NewBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BookTitle = new TextBox();
            BookAuthor = new TextBox();
            BookWritingYear = new TextBox();
            NewBookButton = new Button();
            SuspendLayout();
            // 
            // BookTitle
            // 
            BookTitle.Location = new Point(108, 44);
            BookTitle.Name = "BookTitle";
            BookTitle.Size = new Size(192, 25);
            BookTitle.TabIndex = 0;
            // 
            // BookAuthor
            // 
            BookAuthor.Location = new Point(108, 87);
            BookAuthor.Name = "BookAuthor";
            BookAuthor.Size = new Size(192, 25);
            BookAuthor.TabIndex = 1;
            // 
            // BookWritingYear
            // 
            BookWritingYear.Location = new Point(108, 133);
            BookWritingYear.Name = "BookWritingYear";
            BookWritingYear.Size = new Size(192, 25);
            BookWritingYear.TabIndex = 2;
            // 
            // NewBookButton
            // 
            NewBookButton.Location = new Point(133, 187);
            NewBookButton.Name = "NewBookButton";
            NewBookButton.Size = new Size(141, 34);
            NewBookButton.TabIndex = 3;
            NewBookButton.Text = "Add a book";
            NewBookButton.UseVisualStyleBackColor = true;
            NewBookButton.Click += button1_Click;
            // 
            // NewBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 255);
            Controls.Add(NewBookButton);
            Controls.Add(BookWritingYear);
            Controls.Add(BookAuthor);
            Controls.Add(BookTitle);
            Name = "NewBookForm";
            Text = "NewBookForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox BookTitle;
        private TextBox BookAuthor;
        private TextBox BookWritingYear;
        private Button NewBookButton;
    }
}