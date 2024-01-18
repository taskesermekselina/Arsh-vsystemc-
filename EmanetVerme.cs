using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProjeOdev
{
    public partial class Form4 : Form
    {
        public Form4()
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
            bindingSource1.DataSource = GetData("Select * From Emanet_islemleri");
            dataGridView1.DataSource = bindingSource1;
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            TabloyuDoldur();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            TabloyuDoldur();
        }

        private void btnAraEvrak_Click(object sender, EventArgs e)
        {
            string kayıt = "Select * From Emanet_islemleri Where Evrak_adi=@p0";
            MySqlCommand command = new MySqlCommand(kayıt, connection);

            command.Parameters.AddWithValue("p0", textBox1.Text);

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand commandToAdd = new MySqlCommand("INSERT INTO Emanet_islemleri(Tc,Ad_soyad,Telefon,Email,Evrak_adi,Evrak_turu,Aciklama,Raf_no,Teslim_tarihi,Iade_tarihi) VALUES (@p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", connection);
            commandToAdd.Parameters.AddWithValue("@p0", tctxt.Text);
            commandToAdd.Parameters.AddWithValue("@p1", adstxt.Text);
            commandToAdd.Parameters.AddWithValue("@p2", teltxt.Text);
            commandToAdd.Parameters.AddWithValue("@p3", mailtxt.Text);
            commandToAdd.Parameters.AddWithValue("@p4", evrktxt.Text);
            commandToAdd.Parameters.AddWithValue("@p5", comboBox1.Text);
            commandToAdd.Parameters.AddWithValue("@p6", aciklama2txt.Text);
            commandToAdd.Parameters.AddWithValue("@p7", raf2txt.Text);
            commandToAdd.Parameters.AddWithValue("@p8", dateTimePicker1.Text);
            commandToAdd.Parameters.AddWithValue("@p9", dateTimePicker2.Text);

            MessageBox.Show("Evrak başarıyla emanet verildi");
            commandToAdd.ExecuteNonQuery();
            connection.Close();
            TabloyuDoldur();
        }

        private void tctxt_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand commandToAdd = new MySqlCommand("Select * From Memur Where tc like '" + tctxt.Text + "'", connection);
            MySqlDataReader reader = commandToAdd.ExecuteReader();
            while (reader.Read())
            {
                adstxt.Text = reader["Ad_soyad"].ToString();
                teltxt.Text = reader["Telefon_no"].ToString();
                mailtxt.Text = reader["Email"].ToString();
            }
            connection.Close();
            if (tctxt.Text == "")
            {
                foreach (Control item in groupBox1.Controls)
                {
                    item.Text = "";
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void evrktxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form2 form4gecis = new Form2();
            form4gecis.ShowDialog();
            this.Hide();
        }
    }
}
