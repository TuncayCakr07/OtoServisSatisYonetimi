using DevExpress.Utils;
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
    public partial class AracYonetimi : Form
    {
        public AracYonetimi()
        {
            InitializeComponent();
        }
        AracManager manager = new AracManager();
        MarkaManager markaManager = new MarkaManager();
        void Yukle()
        {
           dgvAraclar.DataSource = manager.GetAll();
           cbMarka.DataSource = markaManager.GetAll();
            cbMarka.DisplayMember = "Adi";
            cbMarka.ValueMember = "Id";
        }

        void Temizle()
        {
            var nesneler = groupBox1.Controls.OfType<TextBox>();
            foreach (var item in nesneler)
            {
                item.Clear();
            }
            lblID.Text = "0";
        }

        private void AracYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void dgvAraclar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblID.Text = dgvAraclar.CurrentRow.Cells[0].Value.ToString();
                int aracId=Convert.ToInt32(lblID.Text);
                var arac = manager.Find(aracId);
                TxtFiyat.Text=arac.Fiyat.ToString();
                TxtKasaTipi.Text = arac.KasaTipi;
                TxtModel.Text = arac.Modeli;
                TxtModelYili.Text=arac.ModelYili.ToString();
                TxtAracBilgileri.Text = arac.AracBilgileri;
                TxtRenk.Text = arac.Renk;
                cbSatisDurumu.Checked=arac.SatisDurumu;
                cbMarka.SelectedValue= arac.MarkaId;
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Kayıt Yüklenemedi!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.Add(new Arac
                {
                    Fiyat=Convert.ToDecimal(TxtFiyat.Text),
                    KasaTipi=TxtKasaTipi.Text,
                    MarkaId=Convert.ToInt32(cbMarka.SelectedValue),
                    Modeli=TxtModel.Text,
                    ModelYili=Convert.ToInt32(TxtModelYili.Text),
                    AracBilgileri=TxtAracBilgileri.Text,
                    Renk=TxtRenk.Text,
                    SatisDurumu=cbSatisDurumu.Checked,
                });

                if (sonuc>0)
                {
                    Temizle();
                    Yukle();
                    MessageBox.Show("Yeni Araç Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata! Kayıt Eklenemedi!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblID.Text=="0")
                {
                    MessageBox.Show("Listeden Güncellenecek Kaydı Seçiniz!","Uyarı!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    var sonuc = manager.Update(new Arac
                    {
                        Id=Convert.ToInt32(lblID.Text),
                        Fiyat = Convert.ToDecimal(TxtFiyat.Text),
                        KasaTipi = TxtKasaTipi.Text,
                        MarkaId = Convert.ToInt32(cbMarka.SelectedValue),
                        Modeli = TxtModel.Text,
                        ModelYili = Convert.ToInt32(TxtModelYili.Text),
                        AracBilgileri = TxtAracBilgileri.Text,
                        Renk = TxtRenk.Text,
                        SatisDurumu = cbSatisDurumu.Checked,
                    });

                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Kayıt Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata! Kayıt Güncellenemedi!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {

                if (lblID.Text == "0")
                {
                    MessageBox.Show("Listeden Silinecek Kaydı Seçiniz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var sonuc = manager.Delete(Convert.ToInt32(lblID.Text));
                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Kayıt Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata! Kayıt Silinemedi!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    }

