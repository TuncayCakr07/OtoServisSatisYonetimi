using System;
using System.Linq;
using OtoServisSatis.BL;
using OtoServisSatis.Entities;
using System.Windows.Forms;

namespace OtoServisSatis.WinApp
{
    public partial class ServisYonetimi : Form
    {
        public ServisYonetimi()
        {
            InitializeComponent();
        }

        ServisManager manager = new ServisManager();

        void Yukle()
        {
            dgvServisler.DataSource = manager.GetAll();
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

        private void ServisYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.Add(
                    new Servis
                    {
                        AracPlaka=TxtAracPlaka.Text,
                        AracSorun=TxtAracSorunu.Text,
                        GarantiVarmi=cbGaranti.Checked,
                        KasaTipi=TxtKasaTipi.Text,
                        Marka=TxtMArka.Text,
                        Model=TxtModel.Text,
                        Notlar=TxtNotlar.Text,
                        SaseNo=TxtSaseNo.Text,
                        ServisGelisTarihi=dtServiseGelisTarihi.Value,
                        ServistenCikisTarihi=dtCikisTarihi.Value,
                        ServisUcreti=Convert.ToDecimal(TxtServisUcreti.Text),
                        Yapılanİslemler=TxtYapilanİslemler.Text,
                    }
                    );
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    MessageBox.Show("Kayıt Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu! Kayıt Eklenemedi!\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvServisler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var servis = manager.Find(Convert.ToInt32(dgvServisler.CurrentRow.Cells[0].Value));
                if (servis != null)
                {
                    TxtAracPlaka.Text = servis.AracPlaka;
                    TxtAracSorunu.Text = servis.AracSorun;
                    TxtKasaTipi.Text = servis.KasaTipi;
                    TxtMArka.Text = servis.Marka;
                    TxtModel.Text = servis.Model;
                    TxtNotlar.Text = servis.Notlar;
                    TxtSaseNo.Text = servis.SaseNo;
                    TxtServisUcreti.Text=servis.ServisUcreti.ToString();
                    TxtYapilanİslemler.Text = servis.Yapılanİslemler;
                    dtServiseGelisTarihi.Value = servis.ServisGelisTarihi;
                    dtCikisTarihi.Value = servis.ServistenCikisTarihi;
                    cbGaranti.Checked = servis.GarantiVarmi;
                    lblId.Text=servis.Id.ToString(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu! Kayıt Yüklenemedi!\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text!="0")
                {
                    var sonuc = manager.Update(
                   new Servis
                   {
                       Id = Convert.ToInt32(dgvServisler.CurrentRow.Cells[0].Value),
                       AracPlaka = TxtAracPlaka.Text,
                       AracSorun = TxtAracSorunu.Text,
                       GarantiVarmi = cbGaranti.Checked,
                       KasaTipi = TxtKasaTipi.Text,
                       Marka = TxtMArka.Text,
                       Model = TxtModel.Text,
                       Notlar = TxtNotlar.Text,
                       SaseNo = TxtSaseNo.Text,
                       ServisGelisTarihi = dtServiseGelisTarihi.Value,
                       ServistenCikisTarihi = dtCikisTarihi.Value,
                       ServisUcreti = Convert.ToDecimal(TxtServisUcreti.Text),
                       Yapılanİslemler = TxtYapilanİslemler.Text,
                   }
                   );
                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Kayıt Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Listeden Güncellenecek Kaydı Seçiniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu! Kayıt Güncellemedi!\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show("Satış Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Listeden Silinecek Kaydı Seçiniz!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu! Kayıt Silinemedi!\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
