using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            public tarif(string _name,int _minutes, int _sms, int _gigabytes) : this()
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        int RequiredIndicators;
        int StrokNumber;
        int StrokSum;
        int Difference;

        private void buttonSendSearchTarif_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            //List<tarif> tarifList = new List<tarif>();

            //using (StreamReader sr = new StreamReader(@"Tarifs.txt"))
            //{

            //    while (!sr.EndOfStream)
            //    {
            //        tarif tarif;

            //        tarif.minutes = Convert.ToInt32(sr.ReadLine());
            //        tarif.sms = Convert.ToInt32(sr.ReadLine());
            //        tarif.gigabytes = Convert.ToInt32(sr.ReadLine());

            //        tarifList.Add(tarif);
            //    }

            //    tarif[] tarifArray = tarifList.ToArray();

            //}
            //textBoxGB.Text = Convert.ToString(tarifList[0].gigabytes);
            String tarifOperator = Convert.ToString(comboBoxOperator.Text);
            String tarifOperatorFile="";
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
                tarifs.Add(new tarif(Convert.ToString(rbtarif[0]),Convert.ToInt32(rbtarif[1]), Convert.ToInt32(rbtarif[2]), Convert.ToInt32(rbtarif[3])));
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
            /*using (StreamReader sr = new StreamReader("MTSMax.txt"))
            {
                while (!sr.EndOfStream)
                   slova.Add(sr.ReadLine());
            }
            string[] name = slova[0].Split(' ');
            string[] value = slova[1].Split(' ');
            var reader = new StreamReader("MTSMax.txt");  
            form2.label1.Text = reader.ReadLine();
            form2.label2.Text = reader.ReadLine();
            form2.label3.Text = reader.ReadLine();
            reader.Close();
            */
            this.Hide();
            form2.Show();
        }

    }
}
