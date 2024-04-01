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
    public partial class UnsoldBooks : Form
    {
        Statistic Sta;
        ThongCute Thong;
        public UnsoldBooks()
        {
            InitializeComponent();
        }

        private void statisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sta = new Statistic();
            Sta.Show();
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
