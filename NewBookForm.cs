using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace LibraryApp
{
    //context database = new context();
    public partial class NewBookForm : Form
    {
        public NewBookForm()
        {
            InitializeComponent();
        }
        public string newBookTitle { get; set; }
        public string newBookAuthor { get; set; }
        public int newBookYear { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            newBookTitle = BookTitle.Text;
            newBookAuthor = BookAuthor.Text;
            newBookYear = Convert.ToInt32(BookWritingYear.Text);
            this.Close();
        }
    }
}
