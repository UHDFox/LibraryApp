namespace LibraryApp
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            authorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookBindingSource = new BindingSource(components);
            button1 = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            loginToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            exxitToolStripMenuItem = new ToolStripMenuItem();
            DeleteButton = new Button();
            ChangeBookButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { titleDataGridViewTextBoxColumn, authorDataGridViewTextBoxColumn, yearDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bookBindingSource;
            dataGridView1.Location = new Point(204, 55);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 45;
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.Size = new Size(400, 264);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            titleDataGridViewTextBoxColumn.Width = 110;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            authorDataGridViewTextBoxColumn.HeaderText = "Author";
            authorDataGridViewTextBoxColumn.MinimumWidth = 6;
            authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            authorDataGridViewTextBoxColumn.ReadOnly = true;
            authorDataGridViewTextBoxColumn.Width = 110;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            yearDataGridViewTextBoxColumn.HeaderText = "Year";
            yearDataGridViewTextBoxColumn.MinimumWidth = 6;
            yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            yearDataGridViewTextBoxColumn.ReadOnly = true;
            yearDataGridViewTextBoxColumn.Width = 110;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Data.Entities.Book);
            // 
            // button1
            // 
            button1.Location = new Point(12, 55);
            button1.Name = "button1";
            button1.Size = new Size(134, 44);
            button1.TabIndex = 1;
            button1.Text = "Add a book";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(543, 394);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(18, 18);
            menuStrip1.Items.AddRange(new ToolStripItem[] { loginToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 25);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, exxitToolStripMenuItem });
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(53, 21);
            loginToolStripMenuItem.Text = "Menu";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = SystemColors.Info;
            toolStripMenuItem1.ForeColor = SystemColors.HotTrack;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(118, 24);
            toolStripMenuItem1.Text = "Log in";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // exxitToolStripMenuItem
            // 
            exxitToolStripMenuItem.Name = "exxitToolStripMenuItem";
            exxitToolStripMenuItem.Size = new Size(118, 24);
            exxitToolStripMenuItem.Text = "Exit";
            exxitToolStripMenuItem.Click += exxitToolStripMenuItem_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(12, 116);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(134, 44);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "Delete a book";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ChangeBookButton
            // 
            ChangeBookButton.Location = new Point(12, 175);
            ChangeBookButton.Name = "ChangeBookButton";
            ChangeBookButton.Size = new Size(134, 44);
            ChangeBookButton.TabIndex = 5;
            ChangeBookButton.Text = "Change book info";
            ChangeBookButton.UseVisualStyleBackColor = true;
            ChangeBookButton.Click += ChangeBookButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ChangeBookButton);
            Controls.Add(DeleteButton);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private BindingSource bookBindingSource;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem exxitToolStripMenuItem;
        private Button DeleteButton;
        private Button ChangeBookButton;
    }
}