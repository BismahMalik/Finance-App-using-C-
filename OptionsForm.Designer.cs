namespace Finance_App
{
    partial class OptionsForm
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
            this.CurrencyConverter = new System.Windows.Forms.Button();
            this.ExchangeRate = new System.Windows.Forms.Button();
            this.InterestRate = new System.Windows.Forms.Button();
            this.SalesTax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CurrencyConverter
            // 
            this.CurrencyConverter.Location = new System.Drawing.Point(26, 26);
            this.CurrencyConverter.Name = "CurrencyConverter";
            this.CurrencyConverter.Size = new System.Drawing.Size(772, 87);
            this.CurrencyConverter.TabIndex = 0;
            this.CurrencyConverter.Text = "Currency Converter";
            this.CurrencyConverter.UseVisualStyleBackColor = true;
            this.CurrencyConverter.Click += new System.EventHandler(this.CurrencyConverter_Click);
            // 
            // ExchangeRate
            // 
            this.ExchangeRate.Location = new System.Drawing.Point(26, 119);
            this.ExchangeRate.Name = "ExchangeRate";
            this.ExchangeRate.Size = new System.Drawing.Size(772, 93);
            this.ExchangeRate.TabIndex = 1;
            this.ExchangeRate.Text = "Exchange Rate";
            this.ExchangeRate.UseVisualStyleBackColor = true;
            this.ExchangeRate.Click += new System.EventHandler(this.ExchangeRate_Click);
            // 
            // InterestRate
            // 
            this.InterestRate.Location = new System.Drawing.Point(26, 218);
            this.InterestRate.Name = "InterestRate";
            this.InterestRate.Size = new System.Drawing.Size(772, 107);
            this.InterestRate.TabIndex = 2;
            this.InterestRate.Text = "Interest Rate";
            this.InterestRate.UseVisualStyleBackColor = true;
            this.InterestRate.Click += new System.EventHandler(this.InterestRate_Click);
            // 
            // SalesTax
            // 
            this.SalesTax.Location = new System.Drawing.Point(26, 331);
            this.SalesTax.Name = "SalesTax";
            this.SalesTax.Size = new System.Drawing.Size(772, 101);
            this.SalesTax.TabIndex = 3;
            this.SalesTax.Text = "Sales Tax";
            this.SalesTax.UseVisualStyleBackColor = true;
            this.SalesTax.Click += new System.EventHandler(this.SalesTax_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 466);
            this.Controls.Add(this.SalesTax);
            this.Controls.Add(this.InterestRate);
            this.Controls.Add(this.ExchangeRate);
            this.Controls.Add(this.CurrencyConverter);
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CurrencyConverter;
        private System.Windows.Forms.Button ExchangeRate;
        private System.Windows.Forms.Button InterestRate;
        private System.Windows.Forms.Button SalesTax;
    }
}