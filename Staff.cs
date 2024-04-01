using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongSach
{
    public partial class Staff : Form
    {
        Menu Admin;
        public Staff()
        {
            InitializeComponent();
        }

        private void returnToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin = new Menu();
            Admin.Show();
            this.Close();
        }
    }
}
