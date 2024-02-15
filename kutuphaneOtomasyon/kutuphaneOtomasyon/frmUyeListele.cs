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
    public partial class frmUyeListele : Form
    {
        public frmUyeListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Kutuphane;Integrated Security=True");

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dataGridView1.CurrentRow.Cells["Tc"].Value.ToString();
        }
        private void uyeListele()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Uye", baglanti);
            adapter.Fill(ds, "Uye");
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();

        }
        private void frmUyeListele_Load(object sender, EventArgs e)
        {
            uyeListele();
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from Uye where Tc like '"+txtTc.Text+"'", baglanti);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read()) 
            {
                txtAdSoyad.Text = rdr["adSoyad"].ToString();
                txtYas.Text = rdr["yas"].ToString();
                comboBox1.Text = rdr["cinsiyet"].ToString();
                txtTelefon.Text = rdr["telefon"].ToString();
                txtAdres.Text = rdr["adres"].ToString();
                txtEmail.Text = rdr["email"].ToString();
                txtOkunanKitap.Text = rdr["okunanKitapSayisi"].ToString();
                
            }
            baglanti.Close();
        }
        DataSet ds = new DataSet();
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            ds.Tables["Uye"].Clear();
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Uye where Tc like '%"+txtAra.Text+"'",baglanti);
            adapter.Fill(ds,"Uye");
            dataGridView1.DataSource = ds.Tables["Uye"];
            baglanti.Close();

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kaydı silmek istediğinizden emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog==DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from Uye where Tc=@Tc", baglanti);
                cmd.Parameters.AddWithValue("@Tc", dataGridView1.CurrentRow.Cells["Tc"].Value.ToString());
                baglanti.Close();
                MessageBox.Show("Silme işlemi gerçekleşti.");
                ds.Tables["Uye"].Clear();
                uyeListele();

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
            SqlCommand cmd = new SqlCommand("update Uye set adSoyad=@adSoyad, yas=@yas, cinsiyet = @cinsiyet, telefon = @telefon, adres=@adres, email=@email, okunanKitapSayisi=@okunanKitapSayisi where Tc = @Tc", baglanti);
            cmd.Parameters.AddWithValue("@Tc",txtTc.Text);
            cmd.Parameters.AddWithValue("@adSoyad", txtAdSoyad.Text);
            cmd.Parameters.AddWithValue("@yas", txtYas.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", comboBox1.Text);
            cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@adres", txtAdres.Text);
            cmd.Parameters.AddWithValue("@okunanKitapSayisi", int.Parse(txtOkunanKitap.Text));
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi gerçekleştirildi.");
            ds.Tables["Uye"].Clear();
            uyeListele();

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";

                }
            }

        }
    }
}
