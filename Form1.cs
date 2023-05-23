using LibraryApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }
        public context database = new context();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.Books.ToList();
            /* BindingSource bs = new BindingSource();
             bs.DataSource = database.Books.ToList();
             dataGridView1.DataSource = bs;*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Book kniga = database.Books.FirstOrDefault();
            //database.Books.Remove(kniga);
            //database.SaveChanges();
            //Book HarryPotter = new Book { Title = "Harry Potter", Author = "Rowling", Year = 1995 };
            //Book Neuromancer = new Book { Title = "Neuromancer", Author = "Gibson", Year = 1975 };

            //database.Books.Add(HarryPotter);
            //database.Books.Add(Neuromancer);
            /*database.SaveChanges();

            var bookies = database.Books.ToList();

            dataGridView1.DataSource = bookies;*/
            //var titleInput = 

            NewBookForm AddBookForm = new NewBookForm();
            AddBookForm.ShowDialog();
            Book nbook = new Book { Title = AddBookForm.newBookTitle, Author = AddBookForm.newBookAuthor, Year = AddBookForm.newBookYear };
            database.Books.Add(nbook);
            database.SaveChanges();
            dataGridView1.DataSource = database.Books.ToList();



        }

        private void exxitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var selectedCell = dataGridView1.CurrentCell.ColumnIndex;
            Book bookToDelete = database.Books.ElementAt(selectedCell);
            database.Remove(bookToDelete);
            database.SaveChanges();
            dataGridView1.DataSource = database.Books.ToList();
        }

        private void ChangeBookButton_Click(object sender, EventArgs e)
        {
            DataChangeForm dcForm = new DataChangeForm();
            dcForm.ShowDialog();
            dataGridView1.SelectedCells[0].Value = dcForm.StrDataChangeToText;
            try 
            {
                if (dcForm.StrDataChangeToText.GetType() == typeof(string))
                {
                    dataGridView1.SelectedCells[0].Value = dcForm.StrDataChangeToText;
                }
                else dataGridView1.SelectedCells[0].Value = Convert.ToInt32(dcForm.StrDataChangeToText);
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
            database.SaveChanges();
            dataGridView1.DataSource = database.Books.ToList();

        }
    }
}