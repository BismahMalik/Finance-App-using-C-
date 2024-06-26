namespace Finance_App
{
    partial class SalesTaxForm
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
            this.SalesTax = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.textZipcode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(180, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Zip Code";
            // 
            // SalesTax
            // 
            this.SalesTax.Location = new System.Drawing.Point(394, 189);
            this.SalesTax.Name = "SalesTax";
            this.SalesTax.Size = new System.Drawing.Size(209, 51);
            this.SalesTax.TabIndex = 1;
            this.SalesTax.Text = "Sales Tax";
            this.SalesTax.UseVisualStyleBackColor = true;
            this.SalesTax.Click += new System.EventHandler(this.SalesTax_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Result.Location = new System.Drawing.Point(12, 281);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 25);
            this.Result.TabIndex = 2;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // textZipcode
            // 
            this.textZipcode.Location = new System.Drawing.Point(394, 102);
            this.textZipcode.Multiline = true;
            this.textZipcode.Name = "textZipcode";
            this.textZipcode.Size = new System.Drawing.Size(209, 29);
            this.textZipcode.TabIndex = 3;
            this.textZipcode.TextChanged += new System.EventHandler(this.textZipcode_TextChanged);
            // 
            // SalesTaxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 532);
            this.Controls.Add(this.textZipcode);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.SalesTax);
            this.Controls.Add(this.label1);
            this.Name = "SalesTaxForm";
            this.Text = "SalesTaxForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SalesTax;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox textZipcode;
    }
}