
namespace OptimalTrafic
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxOperator = new System.Windows.Forms.ComboBox();
            this.textBoxSMS = new System.Windows.Forms.TextBox();
            this.textBoxMinute = new System.Windows.Forms.TextBox();
            this.Operator = new System.Windows.Forms.Label();
            this.labelSMS = new System.Windows.Forms.Label();
            this.labelMinute = new System.Windows.Forms.Label();
            this.labelGB = new System.Windows.Forms.Label();
            this.textBoxGB = new System.Windows.Forms.TextBox();
            this.buttonSendSearchTarif = new System.Windows.Forms.Button();
            this.erpTextBoxGB = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpTextBoxMinute = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpTextBoxSMS = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpButtonSendSearchTarif = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erpTextBoxGB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTextBoxMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTextBoxSMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpButtonSendSearchTarif)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxOperator
            // 
            this.comboBoxOperator.AutoCompleteCustomSource.AddRange(new string[] {
            "МТС",
            "Мегафон",
            "Билайн"});
            this.comboBoxOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperator.FormattingEnabled = true;
            this.comboBoxOperator.Items.AddRange(new object[] {
            "МТС",
            "Мегафон",
            "Билайн"});
            this.comboBoxOperator.Location = new System.Drawing.Point(402, 281);
            this.comboBoxOperator.Name = "comboBoxOperator";
            this.comboBoxOperator.Size = new System.Drawing.Size(121, 23);
            this.comboBoxOperator.TabIndex = 15;
            // 
            // textBoxSMS
            // 
            this.textBoxSMS.Location = new System.Drawing.Point(402, 244);
            this.textBoxSMS.Name = "textBoxSMS";
            this.textBoxSMS.Size = new System.Drawing.Size(100, 23);
            this.textBoxSMS.TabIndex = 14;
            this.textBoxSMS.Click += new System.EventHandler(this.textBoxSMS_Click);
            this.textBoxSMS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSMS_KeyPress);
            this.textBoxSMS.Leave += new System.EventHandler(this.textBoxSMS_Leave);
            // 
            // textBoxMinute
            // 
            this.textBoxMinute.Location = new System.Drawing.Point(402, 186);
            this.textBoxMinute.Name = "textBoxMinute";
            this.textBoxMinute.Size = new System.Drawing.Size(100, 23);
            this.textBoxMinute.TabIndex = 13;
            this.textBoxMinute.Click += new System.EventHandler(this.textBoxMinute_Click);
            this.textBoxMinute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMinute_KeyPress);
            this.textBoxMinute.Leave += new System.EventHandler(this.textBoxMinute_Leave);
            // 
            // Operator
            // 
            this.Operator.AutoSize = true;
            this.Operator.Location = new System.Drawing.Point(277, 281);
            this.Operator.Name = "Operator";
            this.Operator.Size = new System.Drawing.Size(61, 15);
            this.Operator.TabIndex = 11;
            this.Operator.Text = "Оператор";
            // 
            // labelSMS
            // 
            this.labelSMS.AutoSize = true;
            this.labelSMS.Location = new System.Drawing.Point(277, 244);
            this.labelSMS.Name = "labelSMS";
            this.labelSMS.Size = new System.Drawing.Size(102, 15);
            this.labelSMS.TabIndex = 10;
            this.labelSMS.Text = "Количество СМС";
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.Location = new System.Drawing.Point(277, 186);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(109, 15);
            this.labelMinute.TabIndex = 9;
            this.labelMinute.Text = "Количество минут";
            // 
            // labelGB
            // 
            this.labelGB.AutoSize = true;
            this.labelGB.Location = new System.Drawing.Point(277, 128);
            this.labelGB.Name = "labelGB";
            this.labelGB.Size = new System.Drawing.Size(88, 15);
            this.labelGB.TabIndex = 8;
            this.labelGB.Text = "Количество ГБ";
            // 
            // textBoxGB
            // 
            this.textBoxGB.Location = new System.Drawing.Point(402, 128);
            this.textBoxGB.Name = "textBoxGB";
            this.textBoxGB.Size = new System.Drawing.Size(100, 23);
            this.textBoxGB.TabIndex = 16;
            this.textBoxGB.Click += new System.EventHandler(this.textBoxGB_Click);
            this.textBoxGB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGB_KeyPress);
            this.textBoxGB.Leave += new System.EventHandler(this.textBoxGB_Leave);
            // 
            // buttonSendSearchTarif
            // 
            this.buttonSendSearchTarif.Location = new System.Drawing.Point(402, 329);
            this.buttonSendSearchTarif.Name = "buttonSendSearchTarif";
            this.buttonSendSearchTarif.Size = new System.Drawing.Size(75, 23);
            this.buttonSendSearchTarif.TabIndex = 17;
            this.buttonSendSearchTarif.Text = "Искать";
            this.buttonSendSearchTarif.UseVisualStyleBackColor = true;
            this.buttonSendSearchTarif.Click += new System.EventHandler(this.buttonSendSearchTarif_Click);
            // 
            // erpTextBoxGB
            // 
            this.erpTextBoxGB.ContainerControl = this;
            // 
            // erpTextBoxMinute
            // 
            this.erpTextBoxMinute.ContainerControl = this;
            // 
            // erpTextBoxSMS
            // 
            this.erpTextBoxSMS.ContainerControl = this;
            // 
            // erpButtonSendSearchTarif
            // 
            this.erpButtonSendSearchTarif.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSendSearchTarif);
            this.Controls.Add(this.textBoxGB);
            this.Controls.Add(this.comboBoxOperator);
            this.Controls.Add(this.textBoxSMS);
            this.Controls.Add(this.textBoxMinute);
            this.Controls.Add(this.Operator);
            this.Controls.Add(this.labelSMS);
            this.Controls.Add(this.labelMinute);
            this.Controls.Add(this.labelGB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpTextBoxGB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTextBoxMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTextBoxSMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpButtonSendSearchTarif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxOperator;
        private System.Windows.Forms.TextBox textBoxSMS;
        private System.Windows.Forms.TextBox textBoxMinute;
        private System.Windows.Forms.TextBox textBoxGB;
        private System.Windows.Forms.Label Operator;
        private System.Windows.Forms.Label labelSMS;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.Label labelGB;
        private System.Windows.Forms.Button buttonSendSearchTarif;
        private System.Windows.Forms.ErrorProvider erpTextBoxGB;
        private System.Windows.Forms.ErrorProvider erpTextBoxMinute;
        private System.Windows.Forms.ErrorProvider erpTextBoxSMS;
        private System.Windows.Forms.ErrorProvider erpButtonSendSearchTarif;
    }
}

