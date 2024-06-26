namespace Finance_App
{
    partial class ExchangeRateForm
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
            this.ExchangeRates = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.textCurrencies = new System.Windows.Forms.TextBox();
            this.Results = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExchangeRates
            // 
            this.ExchangeRates.Location = new System.Drawing.Point(372, 213);
            this.ExchangeRates.Name = "ExchangeRates";
            this.ExchangeRates.Size = new System.Drawing.Size(207, 56);
            this.ExchangeRates.TabIndex = 0;
            this.ExchangeRates.Text = "Exchange Rate";
            this.ExchangeRates.UseVisualStyleBackColor = true;
            this.ExchangeRates.Click += new System.EventHandler(this.ExchangeRate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(158, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Currency";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(384, 174);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 20);
            this.Result.TabIndex = 2;
            // 
            // textCurrencies
            // 
            this.textCurrencies.Location = new System.Drawing.Point(372, 119);
            this.textCurrencies.Multiline = true;
            this.textCurrencies.Name = "textCurrencies";
            this.textCurrencies.Size = new System.Drawing.Size(207, 29);
            this.textCurrencies.TabIndex = 3;
            this.textCurrencies.TextChanged += new System.EventHandler(this.textCurrencies_TextChanged);
            // 
            // Results
            // 
            this.Results.AutoSize = true;
            this.Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Results.Location = new System.Drawing.Point(12, 296);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(0, 25);
            this.Results.TabIndex = 4;
            this.Results.Click += new System.EventHandler(this.Results_Click);
            // 
            // ExchangeRateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 466);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.textCurrencies);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExchangeRates);
            this.Name = "ExchangeRateForm";
            this.Text = "ExchangeRateForm";
            this.Load += new System.EventHandler(this.ExchangeRateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExchangeRates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox textCurrencies;
        private System.Windows.Forms.Label Results;
    }
}