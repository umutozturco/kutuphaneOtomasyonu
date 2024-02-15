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
    public partial class frmKitapListele : Form
    {
        public frmKitapListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Kutuphane;Integrated Security=True");
        DataSet ds = new DataSet();

        private void kitapListele()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Kitaplar", baglanti);
            adapter.Fill(ds, "Kitaplar");
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();

        }
        private void frmKitapListele_Load(object sender, EventArgs e)
        {
            kitapListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kaydı silmek istediğinizden emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from Kitaplar where barkodNo=@barkodNo", baglanti);
                cmd.Parameters.AddWithValue("@barkodNo", dataGridView1.CurrentRow.Cells["barkodNo"].Value.ToString());
                baglanti.Close();
                MessageBox.Show("Silme işlemi gerçekleşti.");
                ds.Tables["Kitaplar"].Clear();
                kitapListele();

                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";

                    }
                }
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update Kitaplar set kitapAdi=@kitapAdi, yazari = @yazari, yayinevi=@yayinevi, sayfaSayisi=@sayfaSayisi,turu=@turu, stokAdedi=@stokAdedi, rafNo=@rafNo, aciklama=@aciklama, kayitTarihi=@kayitTarihi where barkodNo = @barkodNo", baglanti);
            cmd.Parameters.AddWithValue("@barkodNo",txtBarkodNo.Text);
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
            MessageBox.Show("Güncelleme işlemi gerçekleştirildi.");
            ds.Tables["Kitaplar"].Clear();
            kitapListele();

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";

                }
            }
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from Kitaplar where barkodNo like '" + txtBarkodNo.Text + "'", baglanti);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                txtYazari.Text = rdr["yazari"].ToString();
                txtKitapAdi.Text = rdr["kitapAdi"].ToString();
                txtYayinEvi.Text = rdr["yayinevi"].ToString();
                txtSayfaSayisi.Text = rdr["sayfaSayisi"].ToString();
                comboBox1.Text = rdr["turu"].ToString();
                txtStokAdedi.Text = rdr["stokAdedi"].ToString();
                txtRafNo.Text = rdr["rafNo"].ToString();
                txtAciklama.Text = rdr["aciklama"].ToString();

            }
            baglanti.Close();
        }

        private void txtBarkodAra_TextChanged(object sender, EventArgs e)
        {
            ds.Tables["Kitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Kitaplar where barkodNo like '%" + txtBarkodAra.Text + "'", baglanti);
            adapter.Fill(ds, "Kitaplar");
            dataGridView1.DataSource = ds.Tables["Kitaplar"];
            baglanti.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
