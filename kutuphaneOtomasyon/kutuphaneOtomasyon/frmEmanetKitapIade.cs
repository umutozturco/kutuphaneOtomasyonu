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
    public partial class frmEmanetKitapIade : Form
    {
        public frmEmanetKitapIade()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Kutuphane;Integrated Security=True");
        DataSet ds = new DataSet();
        private void EmanetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar", baglanti);
            adtr.Fill(ds, "EmanetKitaplar");
            dataGridView1.DataSource = ds.Tables["EmanetKitaplar"];
            baglanti.Close();
        }
        private void frmEmanetKitapIade_Load(object sender, EventArgs e)
        {
            EmanetListele();
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            ds.Tables["EmanetKitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar where Tc like '%"+txtTcAra.Text+"%'",baglanti);
            adtr.Fill(ds, "EmanetKitaplar");
            baglanti.Close();
            if (txtTcAra.Text=="")
            {
                ds.Tables["EmanetKitaplar"].Clear();
                EmanetListele();
            }

        }

        private void txtBarkodNoAra_TextChanged(object sender, EventArgs e)
        {
            ds.Tables["EmanetKitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar where barkodNo like '%" + txtBarkodNoAra.Text + "%'", baglanti);
            adtr.Fill(ds, "EmanetKitaplar");
            baglanti.Close();
            if (txtBarkodNoAra.Text == "")
            {
                ds.Tables["EmanetKitaplar"].Clear();
                EmanetListele();
            }
        }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("delete from EmanetKitaplar where Tc=@Tc and barkodNo = @barkodNo", baglanti);
            cmd.Parameters.AddWithValue("@Tc", dataGridView1.CurrentRow.Cells["Tc"].Value.ToString());
            cmd.Parameters.AddWithValue("@barkodNo", dataGridView1.CurrentRow.Cells["barkodNo"].Value.ToString());
            cmd.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand("update Kitaplar set stokAdedi=stokAdedi+'"+dataGridView1.CurrentRow.Cells["kitapSayisi"].Value.ToString()+"'where barkodNo=@barkodNo",baglanti);
            cmd2.Parameters.AddWithValue("@barkodNo", dataGridView1.CurrentRow.Cells["barkodNo"].Value.ToString());
            cmd2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap iade alındı.");
            ds.Tables["EmanetKitaplar"].Clear();
            EmanetListele();
        }
    }
}
