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
    

    public partial class InterestRateForm : Form
    {
        private const string ApiKey = "3a28e48912msha0b4f04c4b8a759p1b79dejsn167635c5ca59";
        private const string ApiHost = "interest-rate-by-api-ninjas.p.rapidapi.com";
        public InterestRateForm()
        {
            InitializeComponent();
        }

        private void textCentalBank_TextChanged(object sender, EventArgs e)
        {

        }

        private void Result2_Click(object sender, EventArgs e)
        {

        }

        private async void InterestRate_Click(object sender, EventArgs e)
        {
            string userInput = textCentalBank.Text.Trim();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                MessageBox.Show("Please enter valid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://interest-rate-by-api-ninjas.p.rapidapi.com/v1/interestrate?name={userInput}"),
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
                        Result2.Text = $"Interest Rate:\n {result}";


                        
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
