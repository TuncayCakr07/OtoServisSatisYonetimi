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
    public partial class KullaniciYonetimi : System.Web.UI.Page
    {
        KullaniciManager manager = new KullaniciManager();
        RoleManager roleManager = new RoleManager();

        void Yukle()
        {
            var specialquery = (from x in manager.GetAllByInclude("Rol")
                                select new
                                {
                                    Id = x.Id,
                                    Adı = x.Adi,
                                    Soyadı = x.Soyadi,
                                    EMail = x.EMail,
                                    Telefon = x.Telefon,
                                    Kullanıcı_Adı = x.KullaniciAdi,
                                    Durum = x.Durum,
                                    Kayıt_Tarihi = x.KayitTarihi,
                                    Rol = x.Rol.Adi,

                                }).ToList();
            dgvKullanicilar.DataSource = specialquery;
            //dgvKullanicilar.DataSource = manager.GetAll();
            dgvKullanicilar.DataBind();
            cbKullaniciRol.DataSource = roleManager.GetAll();
            cbKullaniciRol.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) Yukle();
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int islemsonucu = manager.Add
                    (
                      new Kullanici
                      {
                          Adi = txtAd.Text,
                          Durum = cbDurum.Checked,
                          KayitTarihi = DateTime.Now,
                          EMail = txtEmail.Text,
                          KullaniciAdi = TxtKullaniciAd.Text,
                          RolId = int.Parse(cbKullaniciRol.SelectedValue.ToString()),
                          Sifre = TxtSifre.Text,
                          Soyadi = txtSoyad.Text,
                          Telefon = txtTelefon.Text,
                      }
                    );
                if (islemsonucu > 0)
                {
                    Response.Redirect("KullaniciYonetimi.aspx");
                }
            }
            catch (Exception)
            {
                MessageBox("Hata Oluştu! Kayıt Edilemedi !");


            }
        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text != "0")
                {
                    int kId = Convert.ToInt32(lblId.Text);
                    int islemsonucu = manager.Update
                  (
                    new Kullanici
                    {
                        Id = kId,
                        Adi = txtAd.Text,
                        Durum = cbDurum.Checked,
                        KayitTarihi = DateTime.Now,
                        EMail = txtEmail.Text,
                        KullaniciAdi = TxtKullaniciAd.Text,
                        RolId = int.Parse(cbKullaniciRol.SelectedValue.ToString()),
                        Sifre = TxtSifre.Text,
                        Soyadi = txtSoyad.Text,
                        Telefon = txtTelefon.Text,
                    }
                  );
                    if (islemsonucu > 0)
                    {
                        Response.Redirect("KullaniciYonetimi.aspx");
                    }
                }

            }
            catch (Exception )
            {
                MessageBox("Hata Oluştu! Kayıt Güncellenemedi !");


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
                    int kId = Convert.ToInt32(lblId.Text);
                    var sonuc = manager.Delete(kId);
                    
                    if (sonuc > 0)
                    {
                        MessageBox("Kayıt Silindi!");
                        Response.Redirect("KullaniciYonetimi.aspx");
                    }
                }
            }
            catch (Exception)
            {

                MessageBox("Hata Oluştu! Kayıt Silinemedi!");
            }
        }

        protected void dgvKullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridViewRow row = dgvKullanicilar.SelectedRow;
                int kId = Convert.ToInt32(row.Cells[1].Text);
                if (kId > 0)
                {
                    var user = manager.Find(kId);
                    txtAd.Text = user.Adi;
                    txtSoyad.Text = user.Soyadi;
                    txtEmail.Text = user.EMail;
                    txtTelefon.Text = user.Telefon;
                    TxtKullaniciAd.Text = user.KullaniciAdi;
                    TxtSifre.Text = user.Sifre;
                    cbDurum.Checked = user.Durum;
                    cbKullaniciRol.SelectedValue = user.RolId.ToString();
                    lblKayitTarihi.Text = user.KayitTarihi.ToString();
                    lblId.Text = user.Id.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox("Kullanıcı Bulunamadı!");
            }
        }
        void MessageBox(string mesaj = "")
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "Uyarı!", $"<script>alert('{mesaj}')</script>");
        }
    }
}