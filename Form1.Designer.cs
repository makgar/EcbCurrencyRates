namespace EcbCurrencyRates
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // btnGetRate
            // 
            this.btnGetRate.Location = new System.Drawing.Point(380, 266);
            this.btnGetRate.Name = "btnGetRate";
            this.btnGetRate.Size = new System.Drawing.Size(75, 23);
            this.btnGetRate.TabIndex = 0;
            this.btnGetRate.Text = "Get rate";
            this.btnGetRate.UseVisualStyleBackColor = true;
            this.btnGetRate.Click += new System.EventHandler(this.btnGetRate_Click);
            // 
            // tmpLabel
            // 
            this.tmpLabel.AutoSize = true;
            this.tmpLabel.Location = new System.Drawing.Point(377, 220);
            this.tmpLabel.Name = "tmpLabel";
            this.tmpLabel.Size = new System.Drawing.Size(35, 13);
            this.tmpLabel.TabIndex = 1;
            this.tmpLabel.Text = "label1";
            // 
            // tmpLabel2
            // 
            this.tmpLabel2.AutoSize = true;
            this.tmpLabel2.Location = new System.Drawing.Point(377, 316);
            this.tmpLabel2.Name = "tmpLabel2";
            this.tmpLabel2.Size = new System.Drawing.Size(35, 13);
            this.tmpLabel2.TabIndex = 2;
            this.tmpLabel2.Text = "label2";
            // 
            // tmpLabel3
            // 
            this.tmpLabel3.AutoSize = true;
            this.tmpLabel3.Location = new System.Drawing.Point(377, 329);
            this.tmpLabel3.Name = "tmpLabel3";
            this.tmpLabel3.Size = new System.Drawing.Size(35, 13);
            this.tmpLabel3.TabIndex = 3;
            this.tmpLabel3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tmpLabel3);
            this.Controls.Add(this.tmpLabel2);
            this.Controls.Add(this.tmpLabel);
            this.Controls.Add(this.btnGetRate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetRate;
        private System.Windows.Forms.Label tmpLabel;
        private System.Windows.Forms.Label tmpLabel2;
        private System.Windows.Forms.Label tmpLabel3;
    }
}

