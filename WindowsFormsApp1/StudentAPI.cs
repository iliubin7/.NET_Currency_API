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
            //var json = File.ReadAllText(@"students.json");
            string json = await downloadData();
            textBox1.Text = json;
            var students = JsonConvert.DeserializeObject< List<Student>>(json);
            listBox1.Items.Clear();
            foreach (var student in students)
                listBox1.Items.Add(student);
            label1.Text = json;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private async Task<string> downloadData()
        {
            HttpClient client = new HttpClient();
            string call = "http://radoslaw.idzikowski.staff.iiar.pwr.wroc.pl/instruction/students.json";
            string json = await client.GetStringAsync(call);
            return json;
        }
    }
}
