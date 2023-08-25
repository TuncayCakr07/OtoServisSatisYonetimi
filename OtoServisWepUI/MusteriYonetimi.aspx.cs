using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OtoServisSatis.BL;
using OtoServisSatis.Entities;

namespace OtoServisWepUI
{
    public partial class MusteriYonetimi : System.Web.UI.Page
    {
        MusteriManager manager = new MusteriManager();
        AracManager aracManager = new AracManager();
        void Yukle()
        {
            dgvMusteriler.DataSource = manager.GetAll();
            dgvMusteriler.DataBind();
            cbAracId.DataSource = aracManager.GetAll();
            cbAracId.DataTextField = "Modeli";
            cbAracId.DataValueField = "Id";
            cbAracId.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Yukle();
            }
        }

        protected void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.Add(new Musteri
                {
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
                    Response.Redirect("MusteriYonetimi.aspx");
                }
            }
            catch (Exception)
            {
                MessageBox("Hata! Kayıt Eklenemedi!");
            }
        }

        protected void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text != "0")
                {
                    var sonuc = manager.Delete(Convert.ToInt32(lblId.Text));
                    if (sonuc > 0)
                    {
                        Response.Redirect("MusteriYonetimi.aspx");
                    }
                }
                else
                {
                    MessageBox("Listeden Silinecek Kaydı Seçiniz!");
                }
            }
            catch (Exception)
            {

                MessageBox("Hata Oluştu ! Kayıt Silinemedi!");
            }
        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text != "0")
                {
                    var sonuc = manager.Update(new Musteri
                    {
                        Id = Convert.ToInt32(lblId.Text),
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
                        Response.Redirect("MusteriYonetimi.aspx");
                    }
                }
                else
                {
                    MessageBox("Listeden Güncellenecek Kaydı Seçiniz!");
                }
            }
            catch (Exception)
            {
                MessageBox("Hata! Kayıt Güncellenemedi!");
            }
        }

        protected void dgvMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridViewRow row = dgvMusteriler.SelectedRow;
                var musteri = manager.Find(Convert.ToInt32(row.Cells[1].Text));
                if (musteri != null)
                {
                    txtAd.Text = musteri.Adi;
                    txtSoyad.Text = musteri.Soyadi;
                    TxtAdres.Text = musteri.Adres;
                    txtEmail.Text = musteri.EMail;
                    TxtNotlar.Text = musteri.Notlar;
                    TxtTcno.Text = musteri.TcNo;
                    cbAracId.SelectedValue = musteri.AracId.ToString();
                    lblId.Text = musteri.Id.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox("Hata! Bilgiler Yüklenemedi!");
            }
        }
        void MessageBox(string mesaj = "")
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "Uyarı!", $"<script>alert('{mesaj}')</script>");
        }
    }
}