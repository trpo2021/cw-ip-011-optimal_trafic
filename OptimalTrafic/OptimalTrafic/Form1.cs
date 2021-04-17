using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptimalTrafic
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

        private void buttonSendSearchTarif_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.label1.Text = this.textBoxGB.Text;
            form2.label2.Text = this.textBoxSMS.Text;
            form2.label3.Text = this.textBoxMinute.Text;
            this.Hide();
            form2.Show();
        }

    }
}
