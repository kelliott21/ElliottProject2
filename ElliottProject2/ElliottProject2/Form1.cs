using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElliottProject2
{
    public partial class frmMain : Form
    {
        LinkedList list = new LinkedList();
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for(int i = 0; i <500; i++)
            {
                list.add(rnd.Next(0,701));
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void txtNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search();
        }

        private void Search()
        {
            int value = 0;
            if (int.TryParse(txtNumber.Text, out value))
            {
                if (list.search(value) == null)
                    MessageBox.Show("The number entered does not exist in the list.");
                else
                    MessageBox.Show("Number has been found in the list.");
            }
            else
                MessageBox.Show("Invalid entry. Must enter an integer value.");
        }
    }
}
