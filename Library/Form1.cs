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
            cbFilterODByCheckedOutPerson.Items.Clear();
            cbFilterODByCheckedOutPerson.Items.AddRange(patrons.ToArray());
            cbFilterCOBooksPatron.Items.Clear();
            cbFilterCOBooksPatron.Items.AddRange(patrons.ToArray());

            allBooksGridView.Rows.Clear();
            List<MediaItem> items = lib.GetMediaItems();
            int r = 0;
            foreach (MediaItem item in items)
            {
                allBooksGridView.Rows.Add();
                allBooksGridView.Rows[r].Cells[0].Value = item.name;
                allBooksGridView.Rows[r].Cells[1].Value = item.type.ToString();
                r++;
            }
        }

        private void cbFilterByCheckedOutPerson_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
