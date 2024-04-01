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
    public partial class ExportSlip : Form
    {
        string Message = "Print Complete!";
        string title = "Notification!";
        DialogResult dr;
        public ExportSlip()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//Print
        {
            MessageBox.Show(Message,title);

        }

        private void button1_Click(object sender, EventArgs e)//Delete
        {
            dr = MessageBox.Show("Are you sure deleting?", "Notification", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox10.Text = "";
                    textBox11.Text = "";
                    textBox12.Text = "";
                    break;
            }
        }
    }
}
