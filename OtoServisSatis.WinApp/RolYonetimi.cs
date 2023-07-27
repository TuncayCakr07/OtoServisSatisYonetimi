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
            lblRolId.Text =string.Empty;
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

        private void dgvRoller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //
                lblRolId.Text= dgvRoller.CurrentRow.Cells[0].Value.ToString();
                TxtRolAdi.Text=dgvRoller.CurrentRow.Cells[1].Value.ToString();

            }
            catch (Exception)
            {

                 MessageBox.Show("Hata Oluştu! Kayıt Atanamadı!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);;
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(lblId.Text) || string.IsNullOrEmpty(TxtRolAdi.Text))
                {
                    MessageBox.Show("Listeden Güncellenecek Kayıt Seçiniz!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int rolId = Convert.ToInt32(dgvRoller.CurrentRow.Cells[0].Value);
                    var sonuc = manager.Update(new Rol
                    {
                        Id = rolId,
                        Adi = TxtRolAdi.Text,

                    });
                    if (sonuc > 0)
                    {
                        Yukle();
                        MessageBox.Show("Rol Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Kayıt Güncellenemedi!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblRolId.Text=="")
                {
                    MessageBox.Show("Listeden Silinecek Kaydı Seçiniz!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var sonuc = manager.Delete(Convert.ToInt32(lblRolId.Text));
                    if (sonuc > 0)
                    {
                        Yukle();
                        MessageBox.Show("Kayıt Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Kayıt Silinemedi!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
