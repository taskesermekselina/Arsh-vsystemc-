using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeOdev
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("Server=172.21.54.148;Port=3306;Database=NYP23-13;User=NYP23-13;Password=Uludag9512357.;");
        DataSet ds = new DataSet();

        private void Form6_Load(object sender, EventArgs e)
        {
            EmanetListele();
            comboBox1.SelectedIndex = 0;
        }
        private void EmanetListele()
        {
            connection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("Select*From Emanet_islemleri", connection);
            adapter.Fill(ds, "Emanet_islemleri");
            dataGridView1.DataSource = ds.Tables["Emanet_islemleri"];
            connection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds.Tables["Emanet_islemleri"].Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                EmanetListele();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("Select*From Emanet_islemleri Where'" + DateTime.Now.ToShortDateString + "'>Iade_tarihi", connection);
                adapter.Fill(ds, "Emanet_islemleri");
                dataGridView1.DataSource = ds.Tables["Emanet_islemleri"];
                connection.Close();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("Select*From Emanet_islemleri Where'" + DateTime.Now.ToShortDateString + "'<=Iade_tarihi", connection);
                adapter.Fill(ds, "Emanet_islemleri");
                dataGridView1.DataSource = ds.Tables["Emanet_islemleri"];
                connection.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form4gecis = new Form2();
            form4gecis.ShowDialog();
            this.Hide();
        }
    }
}
