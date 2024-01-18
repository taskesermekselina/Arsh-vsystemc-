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

namespace ProjeOdev
{
    public partial class Form8 : Form
    {
        public Form8()
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
        public void verisil(int id)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Close();
            connection.Open();
            MySqlCommand commandToAdd = new MySqlCommand("INSERT INTO evrak (Evrak_adi,Evrak_turu,Aciklama,Tarih,Raf_no,K_unvan) VALUES (@p0,@p1,@p2,@p3,@p4,@p5)", connection);
            commandToAdd.Parameters.AddWithValue("@p0", textBox1.Text);
            commandToAdd.Parameters.AddWithValue("@p1", comboBox1.Text);
            commandToAdd.Parameters.AddWithValue("@p2", textBox2.Text);
            commandToAdd.Parameters.AddWithValue("@p3", dateTimePicker1.Text);
            commandToAdd.Parameters.AddWithValue("@p4", textBox4.Text);
            commandToAdd.Parameters.AddWithValue("@p5", comboBox2.Text);

            MessageBox.Show("Evrak başarıyla eklendi");
            commandToAdd.ExecuteNonQuery();
            connection.Close();
            TabloyuDoldur();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            TabloyuDoldur();
        }
        int i = 0;
        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TabloyuDoldur();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string kayıt = "Select * From evrak Where Evrak_adi=@p0";
            MySqlCommand command = new MySqlCommand(kayıt, connection);

            command.Parameters.AddWithValue("p0", textBox3.Text);

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form7 form4gecis = new Form7();
            form4gecis.ShowDialog();
            this.Hide();
        }
    }
}
