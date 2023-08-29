using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OtoServisSatis.BL;
using OtoServisSatis.Entities;

namespace OtoServisWepUI
{
    public partial class ServisYonetimi : System.Web.UI.Page
    {
        ServisManager manager = new ServisManager();

        void Yukle()
        {
            dgvServisler.DataSource = manager.GetAll();
            dgvServisler.DataBind();
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
                    new Servis
                    {
                        AracPlaka = TxtAracPlaka.Text,
                        AracSorun = TxtAracSorunu.Text,
                        GarantiVarmi = cbGaranti.Checked,
                        KasaTipi = TxtKasaTipi.Text,
                        Marka = TxtMArka.Text,
                        Model = TxtModel.Text,
                        Notlar = TxtNotlar.Text,
                        SaseNo = TxtSaseNo.Text,
                        ServisGelisTarihi = dtServiseGelisTarihi.SelectedDate,
                        ServistenCikisTarihi = dtCikisTarihi.SelectedDate,
                        ServisUcreti = Convert.ToDecimal(TxtServisUcreti.Text),
                        Yapılanİslemler = TxtYapilanİslemler.Text,
                    }
                    );
                if (sonuc > 0)
                {
                    Response.Redirect("ServisYonetimi.aspx");
                }
            }
            catch (Exception)
            {
                MessageBox("Hata Oluştu! Kayıt Eklenemedi!");
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
                        Response.Redirect("ServisYonetimi.aspx");
                    }
                }
                else
                {
                    MessageBox("Listeden Silinecek Kaydı Seçiniz!");
                }
            }
            catch (Exception)
            {

                MessageBox("Hata Oluştu! Kayıt Silinemedi!");
            }
        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text != "0")
                {
                    var sonuc = manager.Update(
                   new Servis
                   {
                       Id = Convert.ToInt32(lblId.Text),
                       AracPlaka = TxtAracPlaka.Text,
                       AracSorun = TxtAracSorunu.Text,
                       GarantiVarmi = cbGaranti.Checked,
                       KasaTipi = TxtKasaTipi.Text,
                       Marka = TxtMArka.Text,
                       Model = TxtModel.Text,
                       Notlar = TxtNotlar.Text,
                       SaseNo = TxtSaseNo.Text,
                       ServisGelisTarihi = dtServiseGelisTarihi.SelectedDate,
                       ServistenCikisTarihi = dtCikisTarihi.SelectedDate,
                       ServisUcreti = Convert.ToDecimal(TxtServisUcreti.Text),
                       Yapılanİslemler = TxtYapilanİslemler.Text,
                   }
                   );
                    if (sonuc > 0)
                    {
                        Response.Redirect("ServisYonetimi.aspx");
                    }
                }
                else
                {
                    MessageBox("Hata Oluştu! Kayıt Yüklenemedi!");
                }

            }
            catch (Exception)
            {
                MessageBox("Hata Oluştu! Kayıt Yüklenemedi!");
            }
        }

        protected void dgvServisler_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GridViewRow row = dgvServisler.SelectedRow;
            try
            {
                var servis = manager.Find(Convert.ToInt32(dgvServisler.SelectedRow.Cells[1].Text));
                if (servis != null)
                {
                    TxtAracPlaka.Text = servis.AracPlaka;
                    TxtAracSorunu.Text = servis.AracSorun;
                    TxtKasaTipi.Text = servis.KasaTipi;
                    TxtMArka.Text = servis.Marka;
                    TxtModel.Text = servis.Model;
                    TxtNotlar.Text = servis.Notlar;
                    TxtSaseNo.Text = servis.SaseNo;
                    TxtServisUcreti.Text = servis.ServisUcreti.ToString();
                    TxtYapilanİslemler.Text = servis.Yapılanİslemler;
                    dtServiseGelisTarihi.SelectedDate = servis.ServisGelisTarihi;
                    dtCikisTarihi.SelectedDate = servis.ServistenCikisTarihi;
                    cbGaranti.Checked = servis.GarantiVarmi;
                    lblId.Text = servis.Id.ToString();
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