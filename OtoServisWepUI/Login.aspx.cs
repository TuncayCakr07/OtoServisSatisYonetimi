using System;
using System.Web.UI;
using OtoServisSatis.BL;

namespace OtoServisWepUI
{
    public partial class Login : System.Web.UI.Page
    {
        KullaniciManager manager = new KullaniciManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                var kullanıcı = manager.Get(x => x.KullaniciAdi == TxtKullaniciAdi.Text && x.Sifre == TxtSifre.Text && x.Durum == true);
                if (kullanıcı != null)
                {
                    Session["Admin"] = kullanıcı;
                    Response.Redirect("AnaMenu.aspx");
                }
                else
                {
                    MessageBox("Kullanıcı Girişi Başarısız! Bilgileri Kontrol Ediniz!");
                }
            }
            catch (Exception)
            {
                MessageBox("Hata Oluştu! Kullanıcı Bulunamadı!");
            }
            void MessageBox(string mesaj = "")
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "Uyarı!", $"<script>alert('{mesaj}')</script>");
            }
        }
    }
}