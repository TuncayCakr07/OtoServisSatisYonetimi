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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
         KullaniciManager manager = new KullaniciManager(); 
         
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                var kullanıcı = manager.Get(x => x.KullaniciAdi == TxtKullaniciAdi.Text && x.Sifre == TxtSifre.Text && x.Durum == true);
                if (kullanıcı != null)
                {
                    AnaMenu anaMenu = new AnaMenu();
                    anaMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Girişi Başarısız! Bilgileri Kontrol Ediniz!\n", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu! Kullanıcı Bulunamadı!\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
