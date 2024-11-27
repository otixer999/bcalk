using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Bitcoin_kalkulaator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currencySelector.SelectedItem.ToString() == "EUR")
            {
                resultLabel.Visible = true;
                tulemusLabel.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                float result = float.Parse(bitcoinAmountInput.Text) * (float)newbitcoinrate.Bpi.EUR.rate_float;
                resultLabel.Text = $"{result} {newbitcoinrate.Bpi.EUR.code}";
            }

            if (currencySelector.SelectedItem.ToString() == "USD")
            {
                resultLabel.Visible = true;
                tulemusLabel.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                float result = float.Parse(bitcoinAmountInput.Text) * (float)newbitcoinrate.Bpi.USD.rate_float;
                resultLabel.Text = $"{result} {newbitcoinrate.Bpi.USD.code}";
            }

            if (currencySelector.SelectedItem.ToString() == "GBP")
            {
                resultLabel.Visible = true;
                tulemusLabel.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                float result = float.Parse(bitcoinAmountInput.Text) * (float)newbitcoinrate.Bpi.GBP.rate_float;
                resultLabel.Text = $"{result} {newbitcoinrate.Bpi.GBP.code}";
            }

            if (currencySelector.SelectedItem.ToString() == "EEK")
            {
                resultLabel.Visible = true;
                tulemusLabel.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                float result = float.Parse(bitcoinAmountInput.Text) * (float)newbitcoinrate.Bpi.GBP.rate_float;                result *= (float)(15.6466);
                resultLabel.Text = $"{result} EEK";


            }

        }

        public static BitcoinRates GetRates()
        {
            string url = "https://api.coindesk.com/v1/bpi/currentprice.json";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            BitcoinRates bitcoin;
            using (var responseReader = new StreamReader(webStream))

            {
                var data = responseReader.ReadToEnd();
                bitcoin = JsonConvert.DeserializeObject<BitcoinRates>(data);
            }
            return bitcoin;
        }

        private void resultLabel_TextChanged(object sender, EventArgs e)
        {
            
            }
        }
    }
