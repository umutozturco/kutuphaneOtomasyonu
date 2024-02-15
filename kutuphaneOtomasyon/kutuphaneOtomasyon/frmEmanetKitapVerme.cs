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
    public partial class frmEmanetKitapVerme : Form
    {
        public frmEmanetKitapVerme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Kutuphane;Integrated Security=True");
        DataSet ds = new DataSet();
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void sepetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Sepet",baglanti);
            adtr.Fill(ds, "Sepet");
            dataGridView1.DataSource = ds.Tables["Sepet"];
            baglanti.Close();
        }
        private void kitapSayisi()
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select sum(kitapSayisi) from Sepet", baglanti);
            lblKitapSayisi.Text = cmd.ExecuteScalar().ToString();
            baglanti.Close();
        }
        private void frmEmanetKitapVerme_Load(object sender, EventArgs e)
        {
            
            sepetListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Sepet(barkodNo,kitapAdi,yazari,yayinevi,sayfaSayisi,kitapSayisi,teslimTarihi,iadeTarihi) values(@barkodNo,@kitapAdi,@yazari,@yayinevi,@sayfaSayisi,@kitapSayisi,@teslimTarihi,@iadeTarihi)", baglanti);
            cmd.Parameters.AddWithValue("@barkodNo", txtBarkodNo.Text);
            cmd.Parameters.AddWithValue("@kitapAdi", txtKitapAdi.Text);
            cmd.Parameters.AddWithValue("@yazari", txtYazari.Text);
            cmd.Parameters.AddWithValue("@yayinevi", txtYayinevi.Text);
            cmd.Parameters.AddWithValue("@sayfaSayisi", txtSayfaSayisi.Text);
            cmd.Parameters.AddWithValue("@kitapSayisi", int.Parse(txtKitapSayisi.Text));
            cmd.Parameters.AddWithValue("@teslimTarihi", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@iadeTarihi", dateTimePicker2.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap sepete eklendi.");
            ds.Tables["Sepet"].Clear();
            sepetListele();
            lblKitapSayisi.Text = "";
            kitapSayisi();

            foreach (Control item in grpKitapBilgi.Controls)
            {
                if (item is TextBox)
                {
                    if (item!=txtKitapSayisi)
                    {
                        item.Text = "";
                    }
                }
            }


        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from Uye where Tc like'"+txtTcAra.Text+"'", baglanti);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                txtAdSoyad.Text = rdr["adSoyad"].ToString();
                txtYas.Text = rdr["yas"].ToString();
                txtTelefon.Text = rdr["telefon"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("select sum(kitapSayisi) from EmanetKitaplar where Tc='"+txtTcAra.Text+"'", baglanti);
            lblKayitliKitapSayisi.Text = cmd2.ExecuteScalar().ToString();
            baglanti.Close();
            if (txtTcAra.Text=="")
            {
                foreach (Control item in grpUyeBilgi.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                        
                    }
                    
                }
                lblKayitliKitapSayisi.Text = "";
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Kayıt silinsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
            SqlCommand cmd = new SqlCommand("delete from Sepet where barkodNo='" + dataGridView1.CurrentRow.Cells["barkodNo"].Value.ToString() + "'", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close() ;
            MessageBox.Show("Silme işlemi yapıldı");
            ds.Tables["Sepet"].Clear();
            sepetListele();
            }
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
           
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select * from Kitaplar where barkodNo like '" + txtBarkodNo.Text + "' ", baglanti);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    txtKitapAdi.Text = rdr["kitapAdi"].ToString();
                    txtYazari.Text = rdr["yazari"].ToString();
                    txtYayinevi.Text = rdr["yayinevi"].ToString();
                    txtSayfaSayisi.Text = rdr["sayfaSayisi"].ToString();

                }
                baglanti.Close();
                if (txtBarkodNo.Text == "")
                {
                    foreach (Control item in grpKitapBilgi.Controls)
                    {
                        if (item is TextBox)
                        {
                            if (item != txtKitapSayisi)
                            {
                                item.Text = "";
                            }
                        }
                    }
                }
            
            
        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            if (lblKitapSayisi.Text != "")
            {
                if (lblKayitliKitapSayisi.Text=="" && int.Parse(lblKitapSayisi.Text)<=3 || lblKayitliKitapSayisi.Text!="" && int.Parse(lblKayitliKitapSayisi.Text)+int.Parse(lblKitapSayisi.Text)<=3)
                {
                    if(txtTcAra.Text!=""&& txtAdSoyad.Text!=""&& txtYas.Text!=""&& txtTelefon.Text!="")
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                        {
                            baglanti.Open();
                            SqlCommand cmd = new SqlCommand("insert into EmanetKitaplar(Tc,adSoyad,yas,telefon,barkodNo,kitapAdi,yazari,yayinevi,sayfaSayisi,kitapSayisi,teslimTarihi,iadeTarihi) values (@Tc,@adSoyad,@yas,@telefon,@barkodNo,@kitapAdi,@yazari,@yayinevi,@sayfaSayisi,@kitapSayisi,@teslimTarihi,@iadeTarihi)", baglanti);
                            cmd.Parameters.AddWithValue("@Tc", txtTcAra.Text);
                            cmd.Parameters.AddWithValue("@adSoyad", txtAdSoyad.Text);
                            cmd.Parameters.AddWithValue("@yas", txtYas.Text);
                            cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                            cmd.Parameters.AddWithValue("@barkodNo", dataGridView1.Rows[i].Cells["barkodNo"].Value.ToString());
                            cmd.Parameters.AddWithValue("@kitapAdi", dataGridView1.Rows[i].Cells["kitapAdi"].Value.ToString());
                            cmd.Parameters.AddWithValue("@yazari", dataGridView1.Rows[i].Cells["yazari"].Value.ToString());
                            cmd.Parameters.AddWithValue("@yayinevi", dataGridView1.Rows[i].Cells["yayinevi"].Value.ToString());
                            cmd.Parameters.AddWithValue("@sayfaSayisi", dataGridView1.Rows[i].Cells["sayfaSayisi"].Value.ToString());
                            cmd.Parameters.AddWithValue("@kitapSayisi", dataGridView1.Rows[i].Cells["kitapSayisi"].Value.ToString());
                            cmd.Parameters.AddWithValue("@teslimTarihi", dataGridView1.Rows[i].Cells["teslimTarihi"].Value.ToString());
                            cmd.Parameters.AddWithValue("@iadeTarihi", dataGridView1.Rows[i].Cells["iadeTarihi"].Value.ToString());
                            cmd.ExecuteNonQuery();
                            SqlCommand cmd2 = new SqlCommand("update Uye set okunanKitapSayisi=okunanKitapSayisi+'"+int.Parse(dataGridView1.Rows[i].Cells["kitapSayisi"].Value.ToString())+"'where Tc = '"+txtTcAra.Text+"' ",baglanti);
                            cmd2.ExecuteNonQuery();
                            SqlCommand cmd3 = new SqlCommand("update Kitaplar set stokAdedi=stokAdedi-'" + int.Parse(dataGridView1.Rows[i].Cells["kitapSayisi"].Value.ToString()) + "'where barkodNo = '" + dataGridView1.Rows[i].Cells["barkodNo"].Value.ToString() + "' ", baglanti);
                            cmd3.ExecuteNonQuery();
                            baglanti.Close();
                        }
                        baglanti.Open();
                        SqlCommand cmd4 = new SqlCommand("delete from Sepet", baglanti);
                        cmd4.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Kitap emanet edildi.");
                        ds.Tables["Sepet"].Clear();
                        sepetListele();
                        txtTcAra.Text = "";

                        lblKitapSayisi.Text = "";
                        kitapSayisi();
                        lblKayitliKitapSayisi.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Önce üye ismi seçmeniz gerekir.");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Emanet kitap sayısı 3'ten fazla olamaz");
                }
            }
            else 
            {
                MessageBox.Show("Önce sepete bir kitap ekleyiniz.");
            }








            lblKitapSayisi.Text = "";
            kitapSayisi();
        }
    }
}
