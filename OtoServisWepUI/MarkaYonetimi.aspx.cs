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
    public partial class MarkaYonetimi : System.Web.UI.Page
    {
        MarkaManager manager = new MarkaManager();
        void Yukle()
        {
            dgvMarkalar.DataSource = manager.GetAll();
            dgvMarkalar.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           if(!Page.IsPostBack) Yukle();
        }

        protected void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int islemsonucu = manager.Add
                    (
                      new Marka
                      {
                          Adi = TxtMarkaAdi.Text
                      }
                    );
                if (islemsonucu > 0)
                {
                    Response.Redirect("MarkaYonetimi.aspx");
                }
            }
            catch (Exception)
            {
                MessageBox("Hata Oluştu! Kayıt Eklenemedi !");

            }
        }

        protected void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text == "0")
                {
                    MessageBox("Silinecek Kayıt Bulunamadı!");
                }
                else
                {
                    var marka=manager.Get(int.Parse(lblId.Text));
                    int islemsonuc=manager.Delete(marka);
                    if (islemsonuc>0)
                    {
                        MessageBox("Kayıt Silindi!");
                        Response.Redirect("MarkaYonetimi.aspx");
                    }
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
                    int islemsonucu = manager.Update(
                     new Marka
                     {
                         Id = int.Parse(lblId.Text),
                         Adi = TxtMarkaAdi.Text
                     }
                   );
                    if (islemsonucu > 0)
                    {
                        Response.Redirect("MarkaYonetimi.aspx");
                    }
                }
                else
                {
                    MessageBox("Güncellemek İstediğiniz Kaydı Seçiniz!");
                }
            }
            catch (Exception )
            {
                MessageBox("Hata Oluştu! Kayıt Güncellenemedi !");

            }
        }
        void MessageBox(string mesaj = "")
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "Uyarı!", $"<script>alert('{mesaj}')</script>");
        }

        protected void dgvMarkalar_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            try
            {
                GridViewRow row = dgvMarkalar.SelectedRow;
                int id = Convert.ToInt32(row.Cells[1].Text);

                if (id > 0)
                {
                    var marka = manager.Get(id);
                    lblId.Text = marka.Id.ToString();
                    TxtMarkaAdi.Text = marka.Adi;
                }
            }
            catch (Exception)
            {
                MessageBox("Hata Oluştu!");
            }
        }
    }
}