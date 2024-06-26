using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_App
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void CurrencyConverter_Click(object sender, EventArgs e)
        {
            CurrencyConverterForm currencyConverterForm = new CurrencyConverterForm();
            currencyConverterForm.Show();
        }

        private void ExchangeRate_Click(object sender, EventArgs e)
        {
            ExchangeRateForm exchangeRateForm = new ExchangeRateForm();
            exchangeRateForm.Show();
        }

        private void InterestRate_Click(object sender, EventArgs e)
        {
            InterestRateForm interestRateForm = new InterestRateForm();
            interestRateForm.Show();
        }

        private void SalesTax_Click(object sender, EventArgs e)
        {
            SalesTaxForm salesTaxForm = new SalesTaxForm();
            salesTaxForm.Show();
        }
    }
}
