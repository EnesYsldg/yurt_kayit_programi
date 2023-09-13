using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace YurKayit4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ENES\\SQLEXPRESS;Initial Catalog=YurtKayit;Integrated Security=True");

        private void FrmOgrKayit_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select bolum_ad from bolum", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    CmbBolum.Items.Add(oku[0].ToString());
                }
                baglanti.Close();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
