using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=postgres; user ID=postgres; password=SSSmail.777");
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                baglanti.Open();

                string sql = "insert into musteri (kullaniciadi,sifre,guvsoru) values (@p1,@p2,@p3)";
                NpgsqlCommand komut = new NpgsqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@p1", textBox1.Text);
                komut.Parameters.AddWithValue("@p2", textBox3.Text);
                komut.Parameters.AddWithValue("@p3", textBox2.Text);

                komut.ExecuteNonQuery();




                baglanti.Close();
                MessageBox.Show("Kayıt Eklendi");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Kayıt başarısız" + hata.Message);
            }

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            this.Hide();
        }
    }
    }

