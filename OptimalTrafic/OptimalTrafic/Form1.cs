using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace OptimalTrafic
{
    public partial class Form1 : Form
    {
        public struct tarif
        {
            public string name;
            public int minutes;
            public int sms;
            public int gigabytes;

            public tarif(string _name, int _minutes, int _sms, int _gigabytes) : this()
            {
                this.name = _name;
                this.minutes = _minutes;
                this.sms = _sms;
                this.gigabytes = _gigabytes;
            }
        }

        public Form1()
        {
            InitializeComponent();
            comboBoxOperator.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public int RequiredIndicators;
        int StrokNumber;
        int StrokSum;
        int Difference;


        public void buttonSendSearchTarif_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (string.IsNullOrEmpty(textBoxGB.Text) || string.IsNullOrWhiteSpace(textBoxGB.Text) ||
                string.IsNullOrEmpty(textBoxSMS.Text) || string.IsNullOrWhiteSpace(textBoxSMS.Text) ||
                string.IsNullOrEmpty(textBoxMinute.Text) || string.IsNullOrWhiteSpace(textBoxMinute.Text))
            {
                erpButtonSendSearchTarif.SetError(buttonSendSearchTarif, "Заполните поля");
            }
            else
            {
                erpButtonSendSearchTarif.Clear();
                String tarifOperator = Convert.ToString(comboBoxOperator.Text);
                String tarifOperatorFile = "";
                switch (tarifOperator)
                {
                    case "МТС":
                        tarifOperatorFile = "TarifsMTS.txt";
                        break;
                    case "Мегафон":
                        tarifOperatorFile = "TarifsMegafon.txt";
                        break;
                    case "Билайн":
                        tarifOperatorFile = "TarifsBilain.txt";
                        break;
                }

                RequiredIndicators = Convert.ToInt32(textBoxGB.Text) + Convert.ToInt32(textBoxMinute.Text) + Convert.ToInt32(textBoxSMS.Text);

                List<tarif> tarifs = new List<tarif>();
                string[] s = File.ReadAllLines(tarifOperatorFile);
                for (int i = 0; i < s.Length; i++)
                {
                    string[] rbtarif = s[i].Split(new char[] { ' ' });
                    tarifs.Add(new tarif(Convert.ToString(rbtarif[0]), Convert.ToInt32(rbtarif[1]), Convert.ToInt32(rbtarif[2]), Convert.ToInt32(rbtarif[3])));
                    StrokSum = Convert.ToInt32(rbtarif[1]) + Convert.ToInt32(rbtarif[2]) + Convert.ToInt32(rbtarif[3]);
                    if (i == 0) Difference = Math.Abs(RequiredIndicators - StrokSum);
                    if (Difference > Math.Abs(RequiredIndicators - StrokSum))
                    {
                        Difference = Math.Abs(RequiredIndicators - StrokSum);
                        StrokNumber = i;
                    }
                }

                for (int i = 0; i < s.Length; i++)
                {
                    textBoxGB.Text = Convert.ToString(tarifs[StrokNumber].name);
                }


                form2.label1.Text = Convert.ToString(tarifs[StrokNumber].name);
                form2.label2.Text = Convert.ToString(tarifs[StrokNumber].minutes);
                form2.label3.Text = Convert.ToString(tarifs[StrokNumber].sms);
                form2.label4.Text = Convert.ToString(tarifs[StrokNumber].gigabytes);

                List<String> slova = new List<string>();
                this.Hide();
                form2.Show();
            }
        }

        private void textBoxGB_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9])";
            if (Regex.IsMatch(textBoxGB.Text, pattern))
            {
                erpTextBoxGB.Clear();
                buttonSendSearchTarif.Enabled = true;
            }
            else
            {
                erpTextBoxGB.SetError(textBoxGB, "Введите количество гигабайт");
                buttonSendSearchTarif.Enabled = false;
                return;
            }

        }

        private void textBoxMinute_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9])";
            if (Regex.IsMatch(textBoxMinute.Text, pattern))
            {
                erpTextBoxMinute.Clear();
                buttonSendSearchTarif.Enabled = true;
            }
            else
            {
                erpTextBoxMinute.SetError(textBoxMinute, "Введите количество минут");
                buttonSendSearchTarif.Enabled = false;
                return;
            }
        }

        private void textBoxSMS_Leave(object sender, EventArgs e)
        {

            string pattern = "^([0-9])";
            if (Regex.IsMatch(textBoxSMS.Text, pattern))
            {
                erpTextBoxSMS.Clear();
                buttonSendSearchTarif.Enabled = true;
            }
            else
            {
                erpTextBoxSMS.SetError(textBoxSMS, "Введите количество смс");
                buttonSendSearchTarif.Enabled = false;
                return;
            }
        }

        private void textBoxGB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                e.KeyChar = (char)0;
                return;
            }
        }

        private void textBoxMinute_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                e.KeyChar = (char)0;
                return;
            }
        }

        private void textBoxSMS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                e.KeyChar = (char)0;
                return;
            }
        }

        private void textBoxGB_Click(object sender, EventArgs e)
        {
            textBoxGB.Clear();
        }

        private void textBoxMinute_Click(object sender, EventArgs e)
        {
            textBoxMinute.Clear();
        }

        private void textBoxSMS_Click(object sender, EventArgs e)
        {
            textBoxSMS.Clear();
        }
    }
}
