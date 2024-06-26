namespace Finance_App
{
    partial class CurrencyConverterForm
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
            this.Amount = new System.Windows.Forms.Label();
            this.CurrentCurrency = new System.Windows.Forms.Label();
            this.RequiredCurrency = new System.Windows.Forms.Label();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.textCurrent = new System.Windows.Forms.TextBox();
            this.textRequired = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.Convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Amount.Location = new System.Drawing.Point(255, 75);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(94, 29);
            this.Amount.TabIndex = 0;
            this.Amount.Text = "Amount";
            // 
            // CurrentCurrency
            // 
            this.CurrentCurrency.AutoSize = true;
            this.CurrentCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CurrentCurrency.Location = new System.Drawing.Point(255, 130);
            this.CurrentCurrency.Name = "CurrentCurrency";
            this.CurrentCurrency.Size = new System.Drawing.Size(194, 29);
            this.CurrentCurrency.TabIndex = 1;
            this.CurrentCurrency.Text = "Current Currency";
            // 
            // RequiredCurrency
            // 
            this.RequiredCurrency.AutoSize = true;
            this.RequiredCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RequiredCurrency.Location = new System.Drawing.Point(255, 188);
            this.RequiredCurrency.Name = "RequiredCurrency";
            this.RequiredCurrency.Size = new System.Drawing.Size(215, 29);
            this.RequiredCurrency.TabIndex = 2;
            this.RequiredCurrency.Text = "Required Currency";
            // 
            // textAmount
            // 
            this.textAmount.Location = new System.Drawing.Point(491, 68);
            this.textAmount.Multiline = true;
            this.textAmount.Name = "textAmount";
            this.textAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textAmount.Size = new System.Drawing.Size(147, 36);
            this.textAmount.TabIndex = 3;
            this.textAmount.TextChanged += new System.EventHandler(this.textAmount_TextChanged);
            // 
            // textCurrent
            // 
            this.textCurrent.Location = new System.Drawing.Point(491, 121);
            this.textCurrent.Multiline = true;
            this.textCurrent.Name = "textCurrent";
            this.textCurrent.Size = new System.Drawing.Size(147, 35);
            this.textCurrent.TabIndex = 4;
            this.textCurrent.TextChanged += new System.EventHandler(this.textCurrent_TextChanged);
            // 
            // textRequired
            // 
            this.textRequired.Location = new System.Drawing.Point(491, 180);
            this.textRequired.Multiline = true;
            this.textRequired.Name = "textRequired";
            this.textRequired.Size = new System.Drawing.Size(147, 34);
            this.textRequired.TabIndex = 5;
            this.textRequired.TextChanged += new System.EventHandler(this.textRequired_TextChanged);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Result.Location = new System.Drawing.Point(23, 346);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 25);
            this.Result.TabIndex = 6;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(384, 272);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(227, 54);
            this.Convert.TabIndex = 7;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // CurrencyConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 466);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.textRequired);
            this.Controls.Add(this.textCurrent);
            this.Controls.Add(this.textAmount);
            this.Controls.Add(this.RequiredCurrency);
            this.Controls.Add(this.CurrentCurrency);
            this.Controls.Add(this.Amount);
            this.Name = "CurrencyConverterForm";
            this.Text = "CurrencyConverterForm";
            this.Load += new System.EventHandler(this.CurrencyConverterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label CurrentCurrency;
        private System.Windows.Forms.Label RequiredCurrency;
        private System.Windows.Forms.TextBox textAmount;
        private System.Windows.Forms.TextBox textCurrent;
        private System.Windows.Forms.TextBox textRequired;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button Convert;
    }
}