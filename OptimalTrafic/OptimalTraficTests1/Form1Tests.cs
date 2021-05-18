using Microsoft.VisualStudio.TestTools.UnitTesting;
using OptimalTrafic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace OptimalTrafic.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void validationTextBox()
        {
            Form1 form1 = new Form1();
            form1.Show();
            form1.textBoxGB.Text = "aaa";
            form1.textBoxMinute.Text = "qqq";
            form1.textBoxSMS.Text = "333";
            form1.comboBoxOperator.SelectedIndex = 0;
            Assert.AreEqual(form1.textBoxMinute.Text, "");
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