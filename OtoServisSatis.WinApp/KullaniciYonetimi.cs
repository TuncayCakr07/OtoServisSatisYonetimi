using DevExpress.ClipboardSource.SpreadsheetML;
using OtoServisSatis.BL;
using OtoServisSatis.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
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
        RoleManager roleManager = new RoleManager();
        void Yukle()
        {
            var specialquery = (from x in manager.GetAllByInclude("Rol")
                                select new
                                {
                                    Id=x.Id,
                                    Adı=x.Adi,
                                    Soyadı=x.Soyadi,
                                    EMail=x.EMail,
                                    Telefon=x.Telefon,
                                    Kullanıcı_Adı=x.KullaniciAdi,
                                    Durum=x.Durum,
                                    Kayıt_Tarihi=x.KayitTarihi,
                                    Rol=x.Rol.Adi,

                                }).ToList();
            //dgvKullanicilar.DataSource = manager.GetAll();
            cbKullaniciRol.DataSource = roleManager.GetAll();
            dgvKullanicilar.DataSource = specialquery;
        }



        private void Temizle()
        {
            txtAd.Text = string.Empty;
            txtSoyad.Text = string.Empty;
            TxtKullaniciAd.Text = string.Empty;
            txtEmail.Text = string.Empty;
            TxtSifre.Text = string.Empty;
            txtTelefon.Text = string.Empty;
            lblId.Text = string.Empty;
            lblKayitTarihi.Text = string.Empty; 
        }

        private void KullaniciYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {

            try
            {
                int islemsonucu = manager.Add
                    (
                      new Kullanici
                      {
                          Adi = txtAd.Text,
                          Durum=cbDurum.Checked,
                          KayitTarihi=DateTime.Now,
                          EMail=txtEmail.Text,
                          KullaniciAdi=TxtKullaniciAd.Text,
                          RolId = int.Parse(cbKullaniciRol.SelectedValue.ToString()),
                          Sifre=TxtSifre.Text,
                          Soyadi=txtSoyad.Text,
                          Telefon=txtTelefon.Text,
                      }
                    );
                if (islemsonucu > 0)
                {
                    Yukle();
                    Temizle();
                    MessageBox.Show("Kullanıcı Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu! Kayıt Edilemedi !\nHata Türü: " + hata.GetType().Name + "\nHata Mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void dgvKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int kId = Convert.ToInt32(dgvKullanicilar.CurrentRow.Cells[0].Value);
                if (kId>0)
                {
                    var user = manager.Find(kId);
                    txtAd.Text = user.Adi;
                    txtSoyad.Text = user.Soyadi;
                    txtEmail.Text = user.EMail;
                    txtTelefon.Text = user.Telefon;
                    TxtKullaniciAd.Text = user.KullaniciAdi;
                    TxtSifre.Text= user.Sifre;
                    cbDurum.Checked= user.Durum;
                    cbKullaniciRol.SelectedValue = user.RolId;
                    lblKayitTarihi.Text = user.KayitTarihi.ToString();
                    lblId.Text= user.Id.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Kullanıcı Bulunamadı!","Uyarı!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

            try
            {
                if (lblId.Text!="0")
                {
                    int kId=Convert.ToInt32(lblId.Text); 
                    int islemsonucu = manager.Update
                  (
                    new Kullanici
                    {
                        Id = kId,
                        Adi = txtAd.Text,
                        Durum = cbDurum.Checked,
                        KayitTarihi = DateTime.Now,
                        EMail = txtEmail.Text,
                        KullaniciAdi = TxtKullaniciAd.Text,
                        RolId = int.Parse(cbKullaniciRol.SelectedValue.ToString()),
                        Sifre = TxtSifre.Text,
                        Soyadi = txtSoyad.Text,
                        Telefon = txtTelefon.Text,
                    }
                  );
                    if (islemsonucu > 0)
                    {
                        Yukle();
                        Temizle();
                        MessageBox.Show("Kullanıcı Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
              
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu! Kayıt Güncellenemedi !\nHata Türü: " + hata.GetType().Name + "\nHata Mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text == "0")
                {
                    MessageBox.Show("Silinecek Kayıt Bulunamadı! \nListeden Kayıt Seçiniz !", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int kId = Convert.ToInt32(lblId.Text);
                    var sonuc = manager.Delete(kId);
                    if (sonuc > 0)
                    {
                        Yukle();
                        Temizle();
                        MessageBox.Show("Kayıt Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata Oluştu! Kayıt Silinemedi!\nHata Türü: " + hata.GetType().Name + "\nHata Mesajı: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
