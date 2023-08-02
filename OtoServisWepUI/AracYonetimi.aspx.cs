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
    public partial class AracYonetimi : System.Web.UI.Page
    {
        AracManager manager = new AracManager();
        MarkaManager markaManager = new MarkaManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        void Yukle()
        {
            gvAraclar.DataSource = manager.GetAll();
            gvAraclar.DataBind();
            ddlMarkalar.DataSource = markaManager.GetAll();
            ddlMarkalar.DataBind();
        }

        protected void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.Add(new Arac
                {
                    Fiyat = Convert.ToDecimal(TxtFiyat.Text),
                    KasaTipi = TxtKasa.Text,
                    MarkaId = Convert.ToInt32(ddlMarkalar.SelectedValue),
                    Modeli = TxtModel.Text,
                    ModelYili = Convert.ToInt32(TxtModelYili.Text),
                    Renk = TxtRenk.Text,
                    SatisDurumu = cbSatisDurum.Checked,
                });

                if (sonuc > 0)
                {
                    Response.Redirect("AracYonetimi.aspx");
                }
            }
            catch (Exception)
            {

                MessageBox("Hata! Kayıt Eklenemedi!");
            }
        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {

        }

        protected void BtnSil_Click(object sender, EventArgs e)
        {

        }

       void MessageBox(string mesaj = "")
        {
            ClientScript.RegisterStartupScript(Page.GetType(),"Uyarı!",$"<script>alert('{mesaj}')</script>"); 
        }
    }
}