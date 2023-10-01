using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat
{
    public partial class Form3 : Form
    {
        public int i;
        public Form3()
        {
            InitializeComponent();

            /*WindowState = FormWindowState.Maximized;
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1(i);
            newForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            i = listBox1.SelectedIndex;
        }
    }
}
