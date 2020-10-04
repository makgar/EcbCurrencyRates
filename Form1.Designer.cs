namespace EcbCurrencyRates
{
    partial class RateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetRate = new System.Windows.Forms.Button();
            this.tmpLabel = new System.Windows.Forms.Label();
            this.tmpLabel2 = new System.Windows.Forms.Label();
            this.tmpLabel3 = new System.Windows.Forms.Label();
            this.tbCurCode = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.lblCurCode = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetRate
            // 
            this.btnGetRate.Location = new System.Drawing.Point(94, 64);
            this.btnGetRate.Name = "btnGetRate";
            this.btnGetRate.Size = new System.Drawing.Size(197, 23);
            this.btnGetRate.TabIndex = 0;
            this.btnGetRate.Text = "Get rate";
            this.btnGetRate.UseVisualStyleBackColor = true;
            this.btnGetRate.Click += new System.EventHandler(this.btnGetRate_Click);
            // 
            // tmpLabel
            // 
            this.tmpLabel.AutoSize = true;
            this.tmpLabel.Location = new System.Drawing.Point(297, 15);
            this.tmpLabel.Name = "tmpLabel";
            this.tmpLabel.Size = new System.Drawing.Size(35, 13);
            this.tmpLabel.TabIndex = 1;
            this.tmpLabel.Text = "label1";
            // 
            // tmpLabel2
            // 
            this.tmpLabel2.AutoSize = true;
            this.tmpLabel2.Location = new System.Drawing.Point(297, 69);
            this.tmpLabel2.Name = "tmpLabel2";
            this.tmpLabel2.Size = new System.Drawing.Size(35, 13);
            this.tmpLabel2.TabIndex = 2;
            this.tmpLabel2.Text = "label2";
            // 
            // tmpLabel3
            // 
            this.tmpLabel3.AutoSize = true;
            this.tmpLabel3.Location = new System.Drawing.Point(297, 96);
            this.tmpLabel3.Name = "tmpLabel3";
            this.tmpLabel3.Size = new System.Drawing.Size(35, 13);
            this.tmpLabel3.TabIndex = 3;
            this.tmpLabel3.Text = "label3";
            // 
            // tbCurCode
            // 
            this.tbCurCode.Location = new System.Drawing.Point(94, 12);
            this.tbCurCode.Name = "tbCurCode";
            this.tbCurCode.Size = new System.Drawing.Size(197, 20);
            this.tbCurCode.TabIndex = 4;
            this.tbCurCode.TextChanged += new System.EventHandler(this.tbCurCode_TextChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dddd,MMMM d,yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(94, 38);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(197, 20);
            this.dtpDate.TabIndex = 5;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(94, 93);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(197, 20);
            this.tbResult.TabIndex = 6;
            this.tbResult.TextChanged += new System.EventHandler(this.tbResult_TextChanged);
            // 
            // lblCurCode
            // 
            this.lblCurCode.AutoSize = true;
            this.lblCurCode.Location = new System.Drawing.Point(12, 15);
            this.lblCurCode.Name = "lblCurCode";
            this.lblCurCode.Size = new System.Drawing.Size(76, 13);
            this.lblCurCode.TabIndex = 7;
            this.lblCurCode.Text = "Currency code";
            this.lblCurCode.Click += new System.EventHandler(this.lblCurCode_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(58, 41);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(51, 96);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Result";
            // 
            // RateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 127);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCurCode);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.tbCurCode);
            this.Controls.Add(this.tmpLabel3);
            this.Controls.Add(this.tmpLabel2);
            this.Controls.Add(this.tmpLabel);
            this.Controls.Add(this.btnGetRate);
            this.Name = "RateForm";
            this.Text = "Rates";
            this.Load += new System.EventHandler(this.RateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetRate;
        private System.Windows.Forms.Label tmpLabel;
        private System.Windows.Forms.Label tmpLabel2;
        private System.Windows.Forms.Label tmpLabel3;
        private System.Windows.Forms.TextBox tbCurCode;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label lblCurCode;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblResult;
    }
}

