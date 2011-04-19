using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        Library lib = new OurLibrary();

        public Form1()
        {
            InitializeComponent();
        }

        private void claimFileDirButton_Click(object sender, EventArgs e)
        {
            DialogResult result = databaseFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                databaseFile.Text = databaseFileDialog.FileName;
                lib.OpenLibrary(databaseFileDialog.FileName);
            }

            List<Patron> patrons = lib.GetAllPatrons();
            cbFilterByCheckedOutPerson.Items.AddRange(patrons.ToArray());
        }

        private void cbFilterByCheckedOutPerson_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
