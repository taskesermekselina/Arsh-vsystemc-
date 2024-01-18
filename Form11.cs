using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjeOdev
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            this.Controls.Add(dataGridView1);
        }
        MySqlConnection connection = new MySqlConnection("Server=172.21.54.148;Port=3306;Database=NYP23-13;User=NYP23-13;Password=Uludag9512357.;");
        private BindingSource bindingSource1 = new BindingSource();

        private DataTable GetData(string sqlCommand)
        {


            MySqlCommand command = new MySqlCommand(sqlCommand, connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            return table;



        }
        void TabloyuDoldur()
        {
            connection.Open();
            bindingSource1.DataSource = GetData("Select * From Personel");
            dataGridView1.DataSource = bindingSource1;
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Close();
            connection.Open();
            MySqlCommand commandToAdd = new MySqlCommand("INSERT INTO Personel (Tc,Ad_soyad,Departman,Email,Kullanici_adi,Sifre) VALUES (@p0,@p1,@p2,@p3,@p4,@p5)", connection);
            commandToAdd.Parameters.AddWithValue("@p0", textBox1.Text);
            commandToAdd.Parameters.AddWithValue("@p1", textBox2.Text);
            commandToAdd.Parameters.AddWithValue("@p2", textBox3.Text);
            commandToAdd.Parameters.AddWithValue("@p3", textBox4.Text);
            commandToAdd.Parameters.AddWithValue("@p4", textBox5.Text);
            commandToAdd.Parameters.AddWithValue("@p5", textBox6.Text);

            MessageBox.Show("Personel başarıyla eklendi");
            commandToAdd.ExecuteNonQuery();
            connection.Close();
            TabloyuDoldur();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            TabloyuDoldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TabloyuDoldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form4gecis = new Form2();
            form4gecis.ShowDialog();
            this.Hide();
        }
    }
}
