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
    public partial class frmSiralama : Form
    {
        public frmSiralama()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Kutuphane;Integrated Security=True");
        DataSet ds = new DataSet();

        private void frmSiralama_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Uye order by okunanKitapSayisi desc", baglanti);
            adtr.Fill(ds, "Uye");
            dataGridView1.DataSource = ds.Tables["Uye"];
            baglanti.Close();
            label3.Text = "";
            label4.Text = "";
            label3.Text = ds.Tables["Uye"].Rows[0]["adSoyad"].ToString()+"=";
            label3.Text += ds.Tables["Uye"].Rows[0]["okunanKitapSayisi"].ToString() + "=";
            label4.Text = ds.Tables["Uye"].Rows[dataGridView1.Rows.Count-2]["adSoyad"].ToString() + "=";
            label4.Text += ds.Tables["Uye"].Rows[dataGridView1.Rows.Count - 2]["okunanKitapSayisi"].ToString();
        }
    }
}
