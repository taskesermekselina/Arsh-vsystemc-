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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.Controls.Add(dataGridView3);
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
            dataGridView3.DataSource = table;

            return table;



        }

        void TabloyuDoldur()
        {
            DataTable dt = new DataTable();
            connection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM evrak", connection);
            adapter.Fill(dt);
            dataGridView3.DataSource = dt;
            connection.Close();
        }
        public void verisil(int id)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TabloyuDoldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM evrak WHERE Evrak_id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            TabloyuDoldur();
            MessageBox.Show("Kayit Silindi.");
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            string kayıt = "Select * From evrak Where Evrak_adi=@p0";
            MySqlCommand command = new MySqlCommand(kayıt, connection);

            command.Parameters.AddWithValue("p0", isimAraTxt.Text);

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView3.DataSource = table;
            connection.Close();

        }
        int i = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            string kayitgüncelle = ("Update evrak Set Evrak_adi=@p0,Evrak_turu=@p1,Aciklama=@p2,Tarih=@p3,Raf_no=@p4,K_unvan=@p5  Where Evrak_id=@id");

            MySqlCommand command = new MySqlCommand(kayitgüncelle, connection);

            command.Parameters.AddWithValue("@p0", evrakadıTxt.Text);
            command.Parameters.AddWithValue("@p1", comboBox1.Text);
            command.Parameters.AddWithValue("@p2", acıklamatxt.Text);
            command.Parameters.AddWithValue("@p3", dateTimePicker1.Value);
            command.Parameters.AddWithValue("@p4", rafnotxt.Text);
            command.Parameters.AddWithValue("@p5", comboBox2.Text);
            command.Parameters.AddWithValue("id", dataGridView3.Rows[i].Cells[0].Value);
            command.ExecuteNonQuery();
            MessageBox.Show("Kayıtlar başarıyla güncellendi");
            connection.Close();
            TabloyuDoldur();
        }

        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            evrakadıTxt.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            acıklamatxt.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
            rafnotxt.Text = dataGridView3.CurrentRow.Cells[5].Value.ToString();
            comboBox1.Text = dataGridView3.CurrentRow.Cells[6].Value.ToString();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form4gecis = new Form2();
            form4gecis.ShowDialog();
            this.Hide();
        }
    }
}
