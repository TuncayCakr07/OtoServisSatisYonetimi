using OtoServisSatis.BL;
using OtoServisSatis.Entities;
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
    public partial class RolYonetimi : Form
    {
        public RolYonetimi()
        {
            InitializeComponent();
        }
        RoleManager manager = new RoleManager();
       
        void Yukle()
        {
            dgvRoller.DataSource = manager.GetAll();
        }

        void Temizle()
        {
            TxtRolAdi.Text = string.Empty;
            lblId.Text ="0";
        }

        private void RolYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtRolAdi.Text.Trim().Length>0)
                {
                    var sonuc = manager.Add(new Rol
                    {
                        Adi = TxtRolAdi.Text,

                    });
                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Yeni Rol Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Bilgileri Kontrol Ediniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Question);

                }

            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Kayıt Eklenemedi!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
