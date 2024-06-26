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
    public partial class ExchangeRateForm : Form
    {
        private const string ApiKey = "3a28e48912msha0b4f04c4b8a759p1b79dejsn167635c5ca59";
        private const string ApiHost = "exchange-rate-by-api-ninjas.p.rapidapi.com";

        public ExchangeRateForm()
        {
            InitializeComponent();
        }

        private void ExchangeRateForm_Load(object sender, EventArgs e)
        {

        }



        private void Results_Click(object sender, EventArgs e)
        {

        }

        private void textCurrencies_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void ExchangeRate_Click(object sender, EventArgs e)
        {
            string currenciesPair = textCurrencies.Text;

            if (string.IsNullOrWhiteSpace(currenciesPair))
            {
                MessageBox.Show("Please enter valid currency pair.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://exchange-rate-by-api-ninjas.p.rapidapi.com/v1/exchangerate?pair={currenciesPair}"),
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
                        Results.Text = $"Exchange Rate: \n{result}";


                        Console.WriteLine(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}