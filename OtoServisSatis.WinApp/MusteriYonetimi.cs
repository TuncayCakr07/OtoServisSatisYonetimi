using DevExpress.Utils.DirectXPaint;
using OtoServisSatis.BL;
using OtoServisSatis.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OtoServisSatis.WinApp
{
    public partial class MusteriYonetimi : Form
    {
        public MusteriYonetimi()
        {
            InitializeComponent();
        }
        MusteriManager manager = new MusteriManager();
        AracManager aracManager = new AracManager();
        void Yukle()
        {
            dgvMusteriler.DataSource = manager.GetAll();
            cbAracId.DataSource = aracManager.GetAll();
            cbAracId.DisplayMember = "Modeli";
            cbAracId.ValueMember = "Id";
        }

        void Temizle()
        {
            var nesneler = groupBox1.Controls.OfType<TextBox>();
            foreach (var item in nesneler)
            {
                item.Clear();
            }
            lblId.Text = "0";
        }

        private void MusteriYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.Add(new Musteri
                {
                    Adi=txtAd.Text,
                    Soyadi=txtSoyad.Text,
                    Adres=TxtAdres.Text,
                    AracId=Convert.ToInt32(cbAracId.SelectedValue),
                    EMail=txtEmail.Text,
                    Notlar=TxtNotlar.Text,
                    TcNo=TxtTcno.Text,
                    Telefon=txtTelefon.Text,
                }
                );
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    MessageBox.Show("Yeni Müşteri Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Kayıt Eklenemedi!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var musteri = manager.Find(Convert.ToInt32(dgvMusteriler.CurrentRow.Cells[0].Value));
                if (musteri != null)
                {
                    txtAd.Text = musteri.Adi;
                    txtSoyad.Text = musteri.Soyadi;
                    TxtAdres.Text = musteri.Adres;
                    txtEmail.Text = musteri.EMail;
                    TxtNotlar.Text = musteri.Notlar;
                    TxtTcno.Text = musteri.TcNo;
                    cbAracId.SelectedValue = musteri.AracId;
                    lblId.Text=musteri.Id.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata! Bilgiler Yüklenemedi!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text!="0")
                {
                    var sonuc = manager.Update(new Musteri
                    {
                        Id = Convert.ToInt32(dgvMusteriler.CurrentRow.Cells[0].Value),
                        Adi = txtAd.Text,
                        Soyadi = txtSoyad.Text,
                        Adres = TxtAdres.Text,
                        AracId = Convert.ToInt32(cbAracId.SelectedValue),
                        EMail = txtEmail.Text,
                        Notlar = TxtNotlar.Text,
                        TcNo = TxtTcno.Text,
                        Telefon = txtTelefon.Text,
                    }
                    );
                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Müşteri Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Listeden Güncellenecek Kaydı Seçiniz!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (lblId.Text != "0")
                {
                    var sonuc = manager.Delete(Convert.ToInt32(lblId.Text));
                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Müşteri Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Listeden Silinecek Kaydı Seçiniz!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
