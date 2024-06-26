using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_App
{
    public partial class CurrencyConverterForm : Form
    {
        private const string ApiKey = "3a28e48912msha0b4f04c4b8a759p1b79dejsn167635c5ca59";
        private const string ApiHost = "currency-converter-by-api-ninjas.p.rapidapi.com";

        public CurrencyConverterForm()
        {
            InitializeComponent();
        }

        private void textAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCurrent_TextChanged(object sender, EventArgs e)
        {

        }

        private void textRequired_TextChanged(object sender, EventArgs e)
        {

        }

        private void Result_Click(object sender, EventArgs e)
        {

        }

        private async void Convert_Click(object sender, EventArgs e)
        {
            string fromCurrency = textCurrent.Text;
            string toCurrency = textRequired.Text;
            decimal amount;

            if (string.IsNullOrWhiteSpace(fromCurrency) || string.IsNullOrWhiteSpace(toCurrency) || !decimal.TryParse(textAmount.Text, out amount))
            {
                MessageBox.Show("Please enter valid values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://currency-converter-by-api-ninjas.p.rapidapi.com/v1/convertcurrency?have={fromCurrency}&want={toCurrency}&amount={amount}"),
                    Headers =
            {
                { "X-RapidAPI-Key", ApiKey },
                { "X-RapidAPI-Host", ApiHost },
            },
                };

                try
                {
                    using (var response = await client.SendAsync(request))
                    {
                        response.EnsureSuccessStatusCode();
                        var result = await response.Content.ReadAsStringAsync();
                        Result.Text = $"Converted Amount:\n\n {result}";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void CurrencyConverterForm_Load(object sender, EventArgs e)
        {

        }
    }
}