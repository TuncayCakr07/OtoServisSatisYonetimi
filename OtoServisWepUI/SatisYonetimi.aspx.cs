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
    public partial class SatisYonetimi : System.Web.UI.Page
    {
        SatisManager manager = new SatisManager();
        AracManager AracManager = new AracManager();
        MusteriManager musteriManager = new MusteriManager();
        void Yukle()
        {
            dgvSatislar.DataSource = manager.GetAll();
            dgvSatislar.DataBind();
            cbArac.DataSource = AracManager.GetAll();
            cbArac.DataTextField = "Modeli";
            cbArac.DataValueField = "Id";
            cbArac.DataBind();
            cbMusteri.DataSource = musteriManager.GetAll();
            cbMusteri.DataTextField = "Adi";
            cbMusteri.DataValueField = "Id";
            cbMusteri.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) Yukle();
        }

        protected void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.Add(
                    new Satis
                    {
                        AracId = Convert.ToInt32(cbArac.SelectedValue),
                        MusteriId = Convert.ToInt32(cbMusteri.SelectedValue),
                        SatisFiyati = Convert.ToDecimal(TxtSatisFiyati.Text),
                        SatisTarihi = dtSatisTarihi.SelectedDate,
                    }
                    );
                if (sonuc > 0)
                {
                  Response.Redirect("SatisYonetimi.aspx");
                }
            }
            catch (Exception)
            {

                MessageBox("Hata Oluştu! Satış Kaydedilemedi!");
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
                        Response.Redirect("SatisYonetimi.aspx");
                    }
                }
                else
                {
                    MessageBox("Listeden Silinecek Kaydı Seçiniz!");
                }
            }
            catch (Exception)
            {

                MessageBox("HATA OLUŞTU!");
            }
        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text != "0")
                {
                    var sonuc = manager.Update(
                    new Satis
                    {
                        Id = Convert.ToInt32(lblId.Text),
                        AracId = Convert.ToInt32(cbArac.SelectedValue),
                        MusteriId = Convert.ToInt32(cbMusteri.SelectedValue),
                        SatisFiyati = Convert.ToDecimal(TxtSatisFiyati.Text),
                        SatisTarihi = dtSatisTarihi.SelectedDate,
                    }
                    );
                    if (sonuc > 0)
                    {
                        Response.Redirect("SatisYonetimi.aspx");
                    }
                }
                else
                {
                    MessageBox("Listeden Güncellenecek Kaydı Seçiniz!");
                }

            }
            catch (Exception)
            {

                MessageBox("Hata Oluştu! Satış Kaydedilemedi!");
            }
        }

        protected void dgvSatislar_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = dgvSatislar.SelectedRow;
            try
            {
                var satis = manager.Find(Convert.ToInt32(row.Cells[1].Text));
                if (satis != null)
                {
                    cbArac.SelectedValue = satis.AracId.ToString();
                    cbMusteri.SelectedValue = satis.MusteriId.ToString();
                    TxtSatisFiyati.Text = satis.SatisFiyati.ToString();
                    dtSatisTarihi.SelectedDate = satis.SatisTarihi;
                    lblId.Text = satis.Id.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox("Hata Oluştu! Kayıt Yüklenemedi!");
            }
        }
        void MessageBox(string mesaj = "")
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "Uyarı!", $"<script>alert('{mesaj}')</script>");
        }
    }
}