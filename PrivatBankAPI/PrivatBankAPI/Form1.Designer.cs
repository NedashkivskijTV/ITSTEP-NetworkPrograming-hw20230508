namespace PrivatBankAPI
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
            this.cbCurrenciesList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCurrencyInfo = new System.Windows.Forms.Label();
            this.lbCurrencyName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCurrenciesList
            // 
            this.cbCurrenciesList.FormattingEnabled = true;
            this.cbCurrenciesList.Location = new System.Drawing.Point(12, 27);
            this.cbCurrenciesList.Name = "cbCurrenciesList";
            this.cbCurrenciesList.Size = new System.Drawing.Size(546, 23);
            this.cbCurrenciesList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список доступних валют :";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 66);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(546, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Відправити";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCurrencyInfo);
            this.groupBox1.Controls.Add(this.lbCurrencyName);
            this.groupBox1.Location = new System.Drawing.Point(12, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 186);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lbCurrencyInfo
            // 
            this.lbCurrencyInfo.AutoSize = true;
            this.lbCurrencyInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCurrencyInfo.Location = new System.Drawing.Point(6, 102);
            this.lbCurrencyInfo.Name = "lbCurrencyInfo";
            this.lbCurrencyInfo.Size = new System.Drawing.Size(104, 21);
            this.lbCurrencyInfo.TabIndex = 1;
            this.lbCurrencyInfo.Text = "Currency Info";
            // 
            // lbCurrencyName
            // 
            this.lbCurrencyName.AutoSize = true;
            this.lbCurrencyName.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCurrencyName.Location = new System.Drawing.Point(6, 44);
            this.lbCurrencyName.Name = "lbCurrencyName";
            this.lbCurrencyName.Size = new System.Drawing.Size(70, 46);
            this.lbCurrencyName.TabIndex = 0;
            this.lbCurrencyName.Text = "ccy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 336);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCurrenciesList);
            this.Name = "Form1";
            this.Text = "PrivatBank API";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbCurrenciesList;
        private Label label1;
        private Button btnSend;
        private GroupBox groupBox1;
        private Label lbCurrencyInfo;
        private Label lbCurrencyName;
    }
}