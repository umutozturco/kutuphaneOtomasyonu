using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneOtomasyon
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
            
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            frmUyeEkle uyeEkle = new frmUyeEkle();
            uyeEkle.ShowDialog();
        }

        private void btnUyeListele_Click(object sender, EventArgs e)
        {
            frmUyeListele uyeListele = new frmUyeListele();
            uyeListele.ShowDialog();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            frmKitapEkle kitapEkle = new frmKitapEkle();
            kitapEkle.ShowDialog();
        }

        private void btnKitapListele_Click(object sender, EventArgs e)
        {
            frmKitapListele kitapListele = new frmKitapListele();
            kitapListele.ShowDialog();
        }

        private void btnEmanetVerme_Click(object sender, EventArgs e)
        {
            frmEmanetKitapVerme emanetVerme = new frmEmanetKitapVerme();
            emanetVerme.ShowDialog();
        }

        private void btnEmanetListele_Click(object sender, EventArgs e)
        {
            frmEmanetKitapListele emanetListele = new frmEmanetKitapListele();
            emanetListele.ShowDialog();
        }

        private void btnEmanetIade_Click(object sender, EventArgs e)
        {
            frmEmanetKitapIade emanetIade = new frmEmanetKitapIade();
            emanetIade.ShowDialog();
        }

        private void btnSiralama_Click(object sender, EventArgs e)
        {
            frmSiralama siralama = new frmSiralama();
            siralama.ShowDialog();
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            frmGrafik grafik = new frmGrafik();
            grafik.ShowDialog();
        }
    }
}
