using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjeOdev
{
    public partial class Form5 : Form
    {
        public Form5()
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
            bindingSource1.DataSource = GetData("Select * From evrak");
            dataGridView1.DataSource = bindingSource1;
            connection.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            connection.Close();
            connection.Open();
            MySqlCommand commandToAdd = new MySqlCommand("INSERT INTO evrak (Evrak_adi,Evrak_turu,Aciklama,Tarih,Raf_no,K_unvan) VALUES (@p0,@p1,@p2,@p3,@p4,@p5)", connection);
            commandToAdd.Parameters.AddWithValue("@p0", evraktext.Text);
            commandToAdd.Parameters.AddWithValue("@p1", comboBox1.Text);
            commandToAdd.Parameters.AddWithValue("@p2", acıklamatext.Text);
            commandToAdd.Parameters.AddWithValue("@p3", dateTimePicker1.Value);
            commandToAdd.Parameters.AddWithValue("@p4", raftext.Text);
            commandToAdd.Parameters.AddWithValue("@p5", comboBox2.Text);

            MessageBox.Show("Evrak başarıyla eklendi");
            commandToAdd.ExecuteNonQuery();
            connection.Close();
            TabloyuDoldur();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            TabloyuDoldur();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form5gecis = new Form2();
            form5gecis.ShowDialog();
            this.Hide();
        }
    }
}



