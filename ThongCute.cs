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
    public partial class ThongCute : Form
    {
        Statistic Sta;
        UnsoldBooks Uns;
        public ThongCute()
        {
            InitializeComponent();
        }

        private void statisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sta = new Statistic();
            Sta.Show();
            this.Close();
        }

        private void unsoldBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uns = new UnsoldBooks();
            Uns.Show();
            this.Close();
        }
    }
}
