using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class DataChangeForm : Form
    {
        public DataChangeForm()
        {
            InitializeComponent();
        }
        public string StrDataChangeToText { get; set; }
        private void DataChangeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void ChangeDataButton_Click(object sender, EventArgs e)
        {
            StrDataChangeToText = DataChangeTextBox.Text;
            this.Close();
        }

        
    }
}
