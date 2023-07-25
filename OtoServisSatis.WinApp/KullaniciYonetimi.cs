using OtoServisSatis.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoServisSatis.WinApp
{
    public partial class KullaniciYonetimi : Form
    {
        public KullaniciYonetimi()
        {
            InitializeComponent();
        }
        KullaniciManager manager = new KullaniciManager();
        void Yukle()
        {
            dgvKullanicilar.DataSource = manager.GetAll();
        }
        private void KullaniciYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {

        }
    }
}
