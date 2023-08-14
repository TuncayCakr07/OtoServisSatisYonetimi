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
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Yukle();
        }
    }
}