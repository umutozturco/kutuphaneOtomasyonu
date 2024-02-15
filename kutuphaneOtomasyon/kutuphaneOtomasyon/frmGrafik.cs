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
    public partial class frmGrafik : Form
    {
        public frmGrafik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Kutuphane;Integrated Security=True");
        

        private void frmGrafik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select adSoyad,okunanKitapSayisi from Uye", baglanti);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                chart1.Series["Okunan Kitap Sayısı"].Points.AddXY(rdr["adSoyad"].ToString(), rdr["okunanKitapSayisi"]);
            }
            baglanti.Close();
            chart1.Series["Okunan Kitap Sayısı"].Color = Color.ForestGreen;
        }

    }
}
