using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtoServisSatis.BL;
using OtoServisSatis.Entities;
using System.Windows.Forms;
using DevExpress.Utils.DragDrop;
using DevExpress.Utils.DirectXPaint;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace OtoServisSatis.WinApp
{
    public partial class SatisYonetimi : Form
    {
        public SatisYonetimi()
        {
            InitializeComponent();
        }
        SatisManager manager = new SatisManager();
        AracManager AracManager = new AracManager();
        MusteriManager musteriManager = new MusteriManager();
        void Yukle()
        {
            dgvSatislar.DataSource = manager.GetAll();
            cbArac.DataSource = AracManager.GetAll();
            cbArac.DisplayMember = "Modeli";
            cbArac.ValueMember = "Id";
            cbMusteri.DataSource = musteriManager.GetAll();
            cbMusteri.DisplayMember = "Adi";
            cbMusteri.ValueMember = "Id";
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

        private void SatisYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.Add(
                    new Satis
                    {
                        AracId = Convert.ToInt32(cbArac.SelectedValue),
                        MusteriId = Convert.ToInt32(cbMusteri.SelectedValue),
                        SatisFiyati = Convert.ToDecimal(TxtSatisFiyati.Text),
                        SatisTarihi = dtSatisTarihi.Value,
                    }
                    );
                if (sonuc>0)
                {
                    Temizle();
                    Yukle();
                    MessageBox.Show("Satış Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Satış Kaydedilemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSatislar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var satis = manager.Find(Convert.ToInt32(dgvSatislar.CurrentRow.Cells[0].Value));
                if (satis!=null)
                {
                    cbArac.SelectedValue=satis.AracId;
                    cbMusteri.SelectedValue=satis.MusteriId;
                    TxtSatisFiyati.Text=satis.SatisFiyati.ToString();
                    dtSatisTarihi.Value = satis.SatisTarihi;
                    lblId.Text = satis.Id.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Kayıt Yüklenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text!="0")
                {
                    var sonuc = manager.Update(
                    new Satis
                    {
                        Id = Convert.ToInt32(dgvSatislar.CurrentRow.Cells[0].Value),
                        AracId = Convert.ToInt32(cbArac.SelectedValue),
                        MusteriId = Convert.ToInt32(cbMusteri.SelectedValue),
                        SatisFiyati = Convert.ToDecimal(TxtSatisFiyati.Text),
                        SatisTarihi = dtSatisTarihi.Value,
                    }
                    );
                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Satış Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Listeden Güncellenecek Kaydı Seçiniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Satış Kaydedilemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (Exception)
            {

                MessageBox.Show("HATA OLUŞTU!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
