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

    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
            /*WindowState = FormWindowState.Maximized;
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;*/
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

