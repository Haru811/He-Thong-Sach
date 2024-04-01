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
    public partial class Statistic : Form
    {
        UnsoldBooks Uns;
        ThongCute Thong;
        public Statistic()
        {
            InitializeComponent();
        }

        private void stocksToolStripMenuItem_Click(object sender, EventArgs e)//unsold
        {
            Uns = new UnsoldBooks();
            Uns.Show();
            this.Close();
        }

        private void thongCuteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thong = new ThongCute();
            Thong.Show();
            this.Close();
        }
    }
}
