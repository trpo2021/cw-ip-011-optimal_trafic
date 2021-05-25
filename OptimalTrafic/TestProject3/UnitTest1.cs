using Microsoft.VisualStudio.TestTools.UnitTesting;
using OptimalTrafic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace TestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int Sum;

            Form1 form1 = new Form1();
            form1.Show();
            form1.textBoxGB.Text = "111";
            form1.textBoxMinute.Text = "222";
            form1.textBoxSMS.Text = "333";
            form1.comboBoxOperator.SelectedIndex = 0;
            Sum = Convert.ToInt32(form1.textBoxGB.Text) + Convert.ToInt32(form1.textBoxMinute.Text) + Convert.ToInt32(form1.textBoxSMS.Text);
            Assert.AreEqual(Sum, RequiredIndicators);
            //Assert.IsTrue(form1.buttonSendSearchTarif.Enabled==true);
            //Assert.IsTrue(form1.buttonSendSearchTarif.Enabled=true);
            form1.Close();
            //form1.Close();
            //Thread.Sleep(5000);
            //form1.buttonSendSearchTarif.PerformClick();
            //form1.buttonSendSearchTarif_Click(object sender, EventArgs e);
            //form1.Hide();
            //Thread.Sleep(5000);
            //Form2 form2 = new Form2();
            //form2.Show();

        }
    }
}
