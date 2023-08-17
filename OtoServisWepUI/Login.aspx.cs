using OtoServisSatis.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
                    Response.Redirect("AnaMenu.aspx");
                }
                else
                {
                    MessageBox("Hata Oluştu! Kullanıcı Bulunamadı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox("Hata Oluştu! Kullanıcı Bulunamadı!");
            }
        }


        void MessageBox(string mesaj = "")
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "Uyarı!", $"<script>alert('{mesaj}')</script>");
        }
    }
}