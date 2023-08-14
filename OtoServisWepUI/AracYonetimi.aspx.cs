using System;
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
            try
            {
                if (lblId.Text == "0")
                {
                    MessageBox("Listeden Güncellenecek Kaydı Seçiniz!");
                }
                else
                {
                    var sonuc = manager.Update(new Arac
                    {
                        Id = Convert.ToInt32(lblId.Text),
                        Fiyat = Convert.ToDecimal(TxtFiyat.Text),
                        KasaTipi = TxtKasa.Text,
                        MarkaId = Convert.ToInt32(ddlMarkalar.SelectedValue),
                        Modeli = TxtModel.Text,
                        ModelYili = Convert.ToInt32(TxtModelYili.Text),
                        Renk = TxtRenk.Text,
                        SatisDurumu = cbSatisDurum.Checked,
                        AracBilgileri = TxtNotlar.Text,
                    });

                    if (sonuc > 0)
                    {

                        Response.Redirect("AracYonetimi.aspx");
                    }
                }
            }
            catch (Exception)
            {

                MessageBox("Hata! Kayıt Güncellenemedi!");
            }
        }

        protected void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {

                if (lblId.Text == "0")
                {
                    MessageBox("Listeden Silinecek Kaydı Seçiniz!");
                }
                else
                {
                    var sonuc = manager.Delete(Convert.ToInt32(lblId.Text));
                    if (sonuc > 0)
                    {
                        Response.Redirect("AracYonetimi.aspx");
                    }
                }
            }
            catch (Exception)
            {

                MessageBox("Hata! Kayıt Silinemedi!");
            }
        }

       

       void MessageBox(string mesaj = "")
        {
            ClientScript.RegisterStartupScript(Page.GetType(),"Uyarı!",$"<script>alert('{mesaj}')</script>"); 
        }

        protected void gvAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
                GridViewRow row = gvAraclar.SelectedRow;
                try
                {
                    lblId.Text = row.Cells[1].Text;
                    int aracId = Convert.ToInt32(lblId.Text);
                    var arac = manager.Find(aracId);
                    TxtFiyat.Text = arac.Fiyat.ToString();
                    TxtKasa.Text = arac.KasaTipi;
                    TxtModel.Text = arac.Modeli;
                    TxtModelYili.Text = arac.ModelYili.ToString();
                    TxtRenk.Text = arac.Renk;
                    cbSatisDurum.Checked = arac.SatisDurumu;
                    ddlMarkalar.SelectedValue = arac.MarkaId.ToString();
                }
                catch (Exception)
                {

                    MessageBox("Hata Oluştu! Kayıt Yüklenemedi!");
                }
        }
    }
}