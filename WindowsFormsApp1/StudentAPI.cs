using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace WindowsFormsApp1
{
    public partial class StudentAPI : Form
    {

        public StudentAPI()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            string json = await downloadData();
            Bank cur = JsonConvert.DeserializeObject<Bank>(json);
            label1.Text = cur.rates[0].mid.ToString();
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private async Task<string> downloadData()
        {
            string code = textBox1.Text;
            string table = textBox2.Text;
            HttpClient client = new HttpClient();
            string call = "http://api.nbp.pl/api/exchangerates/rates/" + table + "/" + code + "/?format=json";
            string json = await client.GetStringAsync(call);
            return json; 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
