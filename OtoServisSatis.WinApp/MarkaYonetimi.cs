using DevExpress.XtraExport.Helpers;
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
    public partial class MarkaYonetimi : Form
    {
        public MarkaYonetimi()
        {
            InitializeComponent();
        }
        MarkaManager manager = new MarkaManager();
        void Yukle()
        {
            dgvMarkalar.DataSource = manager.GetAll();
        }
        void Temizle()
        {
            lblId.Text = "0";
            TxtMarkaAdi.Text = string.Empty;
        }
        private void dgvMarkalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblId.Text = dgvMarkalar.CurrentRow.Cells[0].Value.ToString();
                TxtMarkaAdi.Text = dgvMarkalar.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!","Hata!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void MarkaYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int islemsonucu = manager.Add
                    (
                      new Entities.Marka
                      {
                          Adi=TxtMarkaAdi.Text
                      }
                    );
                if (islemsonucu>0)
                {
                    Yukle();
                    Temizle();
                    MessageBox.Show("Marka Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu! Kayıt Eklenemedi !","Hata!",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text!="0")
                {
                    int islemsonucu = manager.Update(
                     new Entities.Marka
                     {
                         Id=int.Parse(lblId.Text),
                         Adi = TxtMarkaAdi.Text
                     }
                   );
                    if (islemsonucu > 0)
                    {
                        Yukle();
                        Temizle();
                        MessageBox.Show("Marka Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Güncellemek İstediğiniz Kaydı Seçiniz!","Uyarı!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu! Kayıt Güncellenemedi !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
           try
            {
                if (lblId.Text!="0")
                {
                var marka = manager.Get(int.Parse(lblId.Text));
                    int islemsonucu = manager.Delete(marka); 
                    if (islemsonucu > 0)
                    {
                        Yukle();
                        Temizle();
                        MessageBox.Show("Marka Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Silmek İstediğiniz Kaydı Seçiniz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu! Kayıt Silinemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
