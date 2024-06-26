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
    public partial class SalesTaxForm : Form
    {
        private const string ApiKey = "3a28e48912msha0b4f04c4b8a759p1b79dejsn167635c5ca59";
        private const string ApiHost = "sales-tax-by-api-ninjas.p.rapidapi.com";

        public SalesTaxForm()
        {
            InitializeComponent();
        }

        private void textZipcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void Result_Click(object sender, EventArgs e)
        {

        }


        private async void SalesTax_Click(object sender, EventArgs e)
        {

            string userInput = textZipcode.Text.Trim();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                MessageBox.Show("Please enter a valid ZIP code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://sales-tax-by-api-ninjas.p.rapidapi.com/v1/salestax?zip_code={userInput}"),
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
                        Result.Text = $"Sales Tax for ZIP code {userInput}:\n {result}";

                     
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