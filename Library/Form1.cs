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

            cbFilterODByCheckedOutPerson.Items.Clear();
            cbFilterODByCheckedOutPerson.Items.Add("All");

            cbFilterCOBooksPatron.Items.Clear();
            cbFilterCOBooksPatron.Items.Add("All");

            cbCheckoutTo.Items.Clear();

            if (result == DialogResult.OK)
            {
                databaseFile.Text = databaseFileDialog.FileName;
                lib.OpenLibrary(databaseFileDialog.FileName);
                try
                {
                    List<Patron> patrons = lib.GetAllPatrons();
                    cbFilterODByCheckedOutPerson.Items.AddRange(patrons.ToArray());
                    cbFilterCOBooksPatron.Items.AddRange(patrons.ToArray());
                    cbCheckoutTo.Items.AddRange(patrons.ToArray());

                    UpdateGrids();
                }
                catch (Exception loadingException)
                {

                }
            }
        }

        private void UpdateGrids()
        {
            UpdateAllBooksGrid();
            UpdateAvailableGrid();
            UpdateCheckedOutGrid();
            UpdateOverdueGrid();
        }

        private void UpdateAllBooksGrid()
        {
            allBooksGridView.Rows.Clear();
            List<MediaItem> items = lib.GetMediaItems();
            int r = 0;
            foreach (MediaItem item in items)
            {
                allBooksGridView.Rows.Add();
                allBooksGridView.Rows[r].Tag = item;
                allBooksGridView.Rows[r].Cells[0].Value = item.name;
                allBooksGridView.Rows[r].Cells[1].Value = item.type.ToString();
                string status = "Available";
                if (item.checkout_date != null)
                    status = "Checked Out";
                if (item.due_date != null && item.due_date.Value < currentDate.Value)
                    status = "Overdue";
                allBooksGridView.Rows[r].Cells[2].Value = status;
                if (item.checked_to != null)
                {
                    allBooksGridView.Rows[r].Cells[3].Value = item.checked_to.name;
                    allBooksGridView.Rows[r].Cells[4].Value = item.checkout_date.Value.ToShortDateString();
                    allBooksGridView.Rows[r].Cells[5].Value = item.due_date.Value.ToShortDateString();
                }
                r++;
            }
        }

        private void UpdateAvailableGrid()
        {
            availableGrid.Rows.Clear();
            List<MediaItem> items = lib.GetMediaItems();
            int r = 0;
            foreach (MediaItem item in items)
            {
                if (item.checkout_date != null)
                    continue;
                availableGrid.Rows.Add();
                availableGrid.Rows[r].Tag = item;
                availableGrid.Rows[r].Cells[0].Value = item.name;
                availableGrid.Rows[r].Cells[1].Value = item.type.ToString();
                string status = "Available";
                availableGrid.Rows[r].Cells[2].Value = status;
                r++;
            }
        }

        private void UpdateOverdueGrid()
        {
            List<MediaItem> items = lib.GetCheckedOutMedia(cbFilterODByCheckedOutPerson.SelectedItem as Patron);
            overDueGrid.Rows.Clear();
            int r = 0;
            foreach (MediaItem item in items)
            {
                if (item.due_date.Value > currentDate.Value)
                    continue;
                
                overDueGrid.Rows.Add();
                overDueGrid.Rows[r].Tag = item;
                overDueGrid.Rows[r].Cells[0].Value = item.name;
                overDueGrid.Rows[r].Cells[1].Value = item.type.ToString();
                string status = "Overdue";
                overDueGrid.Rows[r].Cells[2].Value = status;
                if (item.checked_to != null)
                {
                    overDueGrid.Rows[r].Cells[3].Value = item.checked_to.name;
                    overDueGrid.Rows[r].Cells[4].Value = item.checkout_date.Value.ToShortDateString();
                    overDueGrid.Rows[r].Cells[5].Value = item.due_date.Value.ToShortDateString();
                }
                r++;
            }
        }

        private void UpdateCheckedOutGrid()
        {
            List<MediaItem> items = lib.GetCheckedOutMedia(cbFilterCOBooksPatron.SelectedItem as Patron);
            checkedOutGrid.Rows.Clear();
            int r = 0;
            foreach (MediaItem item in items)
            {
                checkedOutGrid.Rows.Add();
                checkedOutGrid.Rows[r].Tag = item;
                checkedOutGrid.Rows[r].Cells[0].Value = item.name;
                checkedOutGrid.Rows[r].Cells[1].Value = item.type.ToString();
                string status = "Available";
                if (item.checkout_date != null)
                    status = "Checked Out";
                if (item.due_date != null && item.due_date.Value < currentDate.Value)
                    status = "Overdue";
                checkedOutGrid.Rows[r].Cells[2].Value = status;
                if (item.checked_to != null)
                {
                    checkedOutGrid.Rows[r].Cells[3].Value = item.checked_to.name;
                    checkedOutGrid.Rows[r].Cells[4].Value = item.checkout_date.Value.ToShortDateString();
                    checkedOutGrid.Rows[r].Cells[5].Value = item.due_date.Value.ToShortDateString();
                }
                r++;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // checkout button
            foreach (DataGridViewRow row in availableGrid.SelectedRows)
        	{
                MediaItem item = row.Tag as MediaItem;
                Patron patron = cbCheckoutTo.SelectedItem as Patron;
                item.checked_to = patron;
                item.checkout_date = DateTime.Now;
                DateTime due = DateTime.Now;
                switch (item.type)
                {
                    case MediaType.Adult_book:
                        due += new TimeSpan(14, 0, 0, 0);
                        break;
                    case MediaType.Childs_book:
                        due += new TimeSpan(7, 0, 0, 0);
                        break;
                    case MediaType.Video:
                        due += new TimeSpan(4, 0, 0, 0);
                        break;
                }
                item.due_date = due;
                lib.save(item);
        	}
            UpdateGrids();
        }

        private void currentDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateGrids();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in checkedOutGrid.SelectedRows)
            {
                MediaItem item = row.Tag as MediaItem;
                item.checked_to = null;
                item.checkout_date = null;
                item.due_date = null;
                lib.save(item);
            }
            UpdateGrids();
        }

        private void cbFilterODByCheckedOutPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateOverdueGrid();
        }

        private void cbFilterCOBooksPatron_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCheckedOutGrid();
        }

        private void databaseFile_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
