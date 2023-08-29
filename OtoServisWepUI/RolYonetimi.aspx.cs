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
    public partial class RolYonetimi : System.Web.UI.Page
    {
        RoleManager manager = new RoleManager();

        void Yukle()
        {
            dgvRoller.DataSource = manager.GetAll();
            dgvRoller.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        protected void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtRolAdi.Text.Trim().Length > 0)
                {
                    var sonuc = manager.Add(new Rol
                    {
                        Adi = TxtRolAdi.Text,

                    });
                    if (sonuc > 0)
                    {
                        Response.Redirect("RolYonetimi.aspx");
                    }
                }
                else
                {
                    MessageBox("Bilgileri Kontrol Ediniz!");

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
                if (lblId.Text == "")
                {
                    MessageBox("Listeden Silinecek Kaydı Seçiniz!");
                }
                else
                {
                    var sonuc = manager.Delete(Convert.ToInt32(lblId.Text));
                    if (sonuc > 0)
                    {
                        Response.Redirect("RolYonetimi.aspx");
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
                if (string.IsNullOrEmpty(lblId.Text) || string.IsNullOrEmpty(TxtRolAdi.Text))
                {
                    MessageBox("Listeden Güncellenecek Kayıt Seçiniz!");
                }
                else
                {
                    int rolId = Convert.ToInt32(lblId.Text);
                    var sonuc = manager.Update(new Rol
                    {
                        Id = rolId,
                        Adi = TxtRolAdi.Text,

                    });
                    if (sonuc > 0)
                    {
                        Response.Redirect("RolYonetimi.aspx");
                    }
                }
            }
            catch (Exception)
            {

                MessageBox("Hata Oluştu! Kayıt Güncellenemedi!");
            }
        }

        protected void dgvRoller_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridViewRow row = dgvRoller.SelectedRow;
                lblId.Text = row.Cells[1].Text;
                TxtRolAdi.Text = row.Cells[2].Text;

            }
            catch (Exception)
            {

                MessageBox("Hata Oluştu! Kayıt Atanamadı!"); ;
            }
        }

        void MessageBox(string mesaj = "")
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "Uyarı!", $"<script>alert('{mesaj}')</script>");
        }
    }
}