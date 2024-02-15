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
    public partial class frmEmanetKitapListele : Form
    {
        public frmEmanetKitapListele()
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
        private void frmEmanetKitapListele_Load(object sender, EventArgs e)
        {
            

            EmanetListele();
            comboBox1.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds.Tables["EmanetKitaplar"].Clear();
            if (comboBox1.SelectedIndex==0)
            {
                EmanetListele();
            }
            else if (comboBox1.SelectedIndex==1) 
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar where '"+DateTime.Now.ToShortDateString()+"'>iadeTarihi", baglanti);
                adtr.Fill(ds, "EmanetKitaplar");
                dataGridView1.DataSource = ds.Tables["EmanetKitaplar"];
                baglanti.Close();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar where '" + DateTime.Now.ToShortDateString() + "'<=iadeTarihi", baglanti);
                adtr.Fill(ds, "EmanetKitaplar");
                dataGridView1.DataSource = ds.Tables["EmanetKitaplar"];
                baglanti.Close();
            }

        }
    }
}
