
namespace OptimalTrafic
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSendSearchTarif = new System.Windows.Forms.Button();
            this.textBoxGB = new System.Windows.Forms.TextBox();
            this.textBoxMinute = new System.Windows.Forms.TextBox();
            this.textBoxSMS = new System.Windows.Forms.TextBox();
            this.labelGB = new System.Windows.Forms.Label();
            this.labelMinute = new System.Windows.Forms.Label();
            this.labelSMS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxOperator = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonSendSearchTarif
            // 
            this.buttonSendSearchTarif.Location = new System.Drawing.Point(358, 272);
            this.buttonSendSearchTarif.Name = "buttonSendSearchTarif";
            this.buttonSendSearchTarif.Size = new System.Drawing.Size(75, 23);
            this.buttonSendSearchTarif.TabIndex = 0;
            this.buttonSendSearchTarif.Text = "Искать";
            this.buttonSendSearchTarif.UseVisualStyleBackColor = true;
            this.buttonSendSearchTarif.Click += new System.EventHandler(this.buttonSendSearchTarif_Click);
            // 
            // textBoxGB
            // 
            this.textBoxGB.Location = new System.Drawing.Point(349, 80);
            this.textBoxGB.Name = "textBoxGB";
            this.textBoxGB.Size = new System.Drawing.Size(100, 20);
            this.textBoxGB.TabIndex = 1;
            // 
            // textBoxMinute
            // 
            this.textBoxMinute.Location = new System.Drawing.Point(349, 137);
            this.textBoxMinute.Name = "textBoxMinute";
            this.textBoxMinute.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinute.TabIndex = 2;
            // 
            // textBoxSMS
            // 
            this.textBoxSMS.Location = new System.Drawing.Point(349, 193);
            this.textBoxSMS.Name = "textBoxSMS";
            this.textBoxSMS.Size = new System.Drawing.Size(100, 20);
            this.textBoxSMS.TabIndex = 3;
            // 
            // labelGB
            // 
            this.labelGB.AutoSize = true;
            this.labelGB.Location = new System.Drawing.Point(244, 83);
            this.labelGB.Name = "labelGB";
            this.labelGB.Size = new System.Drawing.Size(82, 13);
            this.labelGB.TabIndex = 4;
            this.labelGB.Text = "Количество ГБ";
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.Location = new System.Drawing.Point(244, 140);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(99, 13);
            this.labelMinute.TabIndex = 5;
            this.labelMinute.Text = "Количество минут";
            // 
            // labelSMS
            // 
            this.labelSMS.AutoSize = true;
            this.labelSMS.Location = new System.Drawing.Point(244, 196);
            this.labelSMS.Name = "labelSMS";
            this.labelSMS.Size = new System.Drawing.Size(92, 13);
            this.labelSMS.TabIndex = 6;
            this.labelSMS.Text = "Количество СМС";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Оператор";
            // 
            // comboBoxOperator
            // 
            this.comboBoxOperator.FormattingEnabled = true;
            this.comboBoxOperator.Items.AddRange(new object[] {
            "МТС",
            "Мегафон",
            "Билайн"});
            this.comboBoxOperator.Location = new System.Drawing.Point(349, 245);
            this.comboBoxOperator.Name = "comboBoxOperator";
            this.comboBoxOperator.Size = new System.Drawing.Size(100, 21);
            this.comboBoxOperator.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxOperator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSMS);
            this.Controls.Add(this.labelMinute);
            this.Controls.Add(this.labelGB);
            this.Controls.Add(this.textBoxSMS);
            this.Controls.Add(this.textBoxMinute);
            this.Controls.Add(this.textBoxGB);
            this.Controls.Add(this.buttonSendSearchTarif);
            this.Name = "Form1";
            this.Text = "Тариф мечты";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSendSearchTarif;
        private System.Windows.Forms.TextBox textBoxGB;
        private System.Windows.Forms.TextBox textBoxMinute;
        private System.Windows.Forms.TextBox textBoxSMS;
        private System.Windows.Forms.Label labelGB;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.Label labelSMS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxOperator;
    }
}

