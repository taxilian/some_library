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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void claimFileDirButton_Click(object sender, EventArgs e)
        {
            DialogResult result = databaseFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                databaseFile.Text = databaseFileDialog.FileName;
            }
        }
    }
}
