namespace Finance_App
{
    partial class InterestRateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Result2 = new System.Windows.Forms.Label();
            this.InterestRate = new System.Windows.Forms.Button();
            this.textCentalBank = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(142, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Central Bank";
            // 
            // Result2
            // 
            this.Result2.AutoSize = true;
            this.Result2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Result2.Location = new System.Drawing.Point(12, 324);
            this.Result2.Name = "Result2";
            this.Result2.Size = new System.Drawing.Size(0, 25);
            this.Result2.TabIndex = 1;
            this.Result2.Click += new System.EventHandler(this.Result2_Click);
            // 
            // InterestRate
            // 
            this.InterestRate.Location = new System.Drawing.Point(361, 211);
            this.InterestRate.Name = "InterestRate";
            this.InterestRate.Size = new System.Drawing.Size(232, 48);
            this.InterestRate.TabIndex = 2;
            this.InterestRate.Text = "Interest Rate";
            this.InterestRate.UseVisualStyleBackColor = true;
            this.InterestRate.Click += new System.EventHandler(this.InterestRate_Click);
            // 
            // textCentalBank
            // 
            this.textCentalBank.Location = new System.Drawing.Point(361, 124);
            this.textCentalBank.Multiline = true;
            this.textCentalBank.Name = "textCentalBank";
            this.textCentalBank.Size = new System.Drawing.Size(239, 29);
            this.textCentalBank.TabIndex = 3;
            this.textCentalBank.TextChanged += new System.EventHandler(this.textCentalBank_TextChanged);
            // 
            // InterestRateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 466);
            this.Controls.Add(this.textCentalBank);
            this.Controls.Add(this.InterestRate);
            this.Controls.Add(this.Result2);
            this.Controls.Add(this.label1);
            this.Name = "InterestRateForm";
            this.Text = "InterestRateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Result2;
        private System.Windows.Forms.Button InterestRate;
        private System.Windows.Forms.TextBox textCentalBank;
    }
}