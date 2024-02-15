using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneOtomasyon
{
    public partial class frmKitapEkle : Form
    {
        public frmKitapEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Kutuphane;Integrated Security=True");
        private void frmKitapEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Kitaplar (barkodNo,kitapAdi,yazari,yayinevi,sayfaSayisi,turu,stokAdedi,rafNo,aciklama,kayitTarihi) values(@barkodNo,@kitapAdi,@yazari,@yayinevi,@sayfaSayisi,@turu,@stokAdedi,@rafNo,@aciklama,@kayitTarihi)", baglanti);
            cmd.Parameters.AddWithValue("@barkodNo", txtBarkodNo.Text);
            cmd.Parameters.AddWithValue("@kitapAdi", txtKitapAdi.Text);
            cmd.Parameters.AddWithValue("@yazari", txtYazari.Text);
            cmd.Parameters.AddWithValue("@yayinevi", txtYayinEvi.Text);
            cmd.Parameters.AddWithValue("@sayfaSayisi", txtSayfaSayisi.Text);
            cmd.Parameters.AddWithValue("@turu", comboBox1.Text);
            cmd.Parameters.AddWithValue("@stokAdedi", txtStokAdedi.Text);
            cmd.Parameters.AddWithValue("@rafNo", txtRafNo.Text);
            cmd.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
            cmd.Parameters.AddWithValue("@kayitTarihi", DateTime.Now.ToShortDateString());
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Kaydı Yapıldı.");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                   
                        item.Text = "";
                    

                }
                if (item is ComboBox)
                {
                    item.Text = "";

                }
            }
        }
    }
}
