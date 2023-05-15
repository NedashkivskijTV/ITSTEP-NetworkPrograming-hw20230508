using Newtonsoft.Json.Linq;
using System.Net;
using System.Text.Json;

namespace PrivatBankAPI
{
    public partial class Form1 : Form
    {
            
        string url = "https://api.privatbank.ua/p24api/pubinfo?json&exchange&coursid=5";

        public Form1()
        {
            InitializeComponent();

            lbCurrencyName.Text = "";
            lbCurrencyInfo.Text = "";
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpRequestMessage message = new HttpRequestMessage())
                {
                    message.Method = HttpMethod.Get;
                    message.RequestUri = new Uri(url);
                    HttpResponseMessage responseMessage = await client.SendAsync(message);
                    string body = await responseMessage.Content.ReadAsStringAsync();
                    List<ExchangeRate> rates = JsonSerializer.Deserialize<List<ExchangeRate>>(body);
                    List<string> ccyList = rates.Select(er => er.ccy).ToList();

                    cbCurrenciesList.BeginInvoke(new Action<List<string>>(ComboBoxUpdate), ccyList);
                }
            }
        }

        private void ComboBoxUpdate(List<string> rates)
        {
            cbCurrenciesList.DataSource = null;
            cbCurrenciesList.DisplayMember = "Name";
            cbCurrenciesList.ValueMember = "Name";
            cbCurrenciesList.DataSource = rates;
            cbCurrenciesList.SelectedIndex = 1;
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpRequestMessage message = new HttpRequestMessage())
                {
                    message.Method = HttpMethod.Get;
                    message.RequestUri = new Uri(url);
                    HttpResponseMessage responseMessage = await client.SendAsync(message);
                    string body = await responseMessage.Content.ReadAsStringAsync();
                    List<ExchangeRate> rates = JsonSerializer.Deserialize<List<ExchangeRate>>(body);

                    //MessageBox.Show(cbCurrenciesList.SelectedItem.ToString());
                    //lbCurrencyName.Text = cbCurrenciesList.SelectedItem.ToString();
                    lbCurrencyName.BeginInvoke(new Action<string>(UpdatelbCurrencyName), cbCurrenciesList.SelectedItem.ToString());

                    ExchangeRate currentrate = rates.Find(r => r.ccy.Equals(cbCurrenciesList.SelectedItem.ToString()));
                    //lbCurrencyInfo.Text = $"курс купівлі: {currentrate.buy} {currentrate.base_ccy} | курс продажу: {currentrate.sale} {currentrate.base_ccy}";
                    lbCurrencyInfo.BeginInvoke(new Action<ExchangeRate>(UpdatelbCurrencyInfo), currentrate);
                }
            }
        }

        private void UpdatelbCurrencyName(string str)
        {
            lbCurrencyName.Text = str;
        }

        private void UpdatelbCurrencyInfo(ExchangeRate currentrate)
        {
            lbCurrencyInfo.Text = $"курс купівлі: {currentrate.buy} {currentrate.base_ccy} | курс продажу: {currentrate.sale} {currentrate.base_ccy}";
        }
    }
}
