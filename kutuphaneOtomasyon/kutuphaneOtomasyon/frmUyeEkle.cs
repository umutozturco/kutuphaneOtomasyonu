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

namespace kutuphaneOtomasyon
{
    public partial class frmUyeEkle : Form
    {
        public frmUyeEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Kutuphane;Integrated Security=True");

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Uye (Tc,adSoyad,yas,cinsiyet,telefon,adres,email,okunanKitapSayisi) values(@Tc,@adSoyad,@yas,@cinsiyet,@telefon,@adres,@email,@okunanKitapSayisi)", baglanti);
            cmd.Parameters.AddWithValue("@Tc", txtTc.Text);
            cmd.Parameters.AddWithValue("@adSoyad", txtAdSoyad.Text);
            cmd.Parameters.AddWithValue("@yas", txtYas.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", comboBox1.Text);
            cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@adres", txtAdres.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@okunanKitapSayisi", txtOkunanKitap.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üye Eklendi.");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if(item!=txtOkunanKitap)
                    {
                        item.Text = "";
                    }
                    
                }
            }
        }

        private void frmUyeEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
