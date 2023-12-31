﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OtoServisSatis.BL;
using OtoServisSatis.Entities;

namespace OtoServisSatis.WebFormUI
{
    public partial class AracYonetimi : System.Web.UI.Page
    {
        AracManager manager = new AracManager();
        MarkaManager markaManager = new MarkaManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        public void Yukle()
        {
            gvAraclar.DataSource = manager.GetAll();
            gvAraclar.DataBind();
            //cbMarka.DataSource = markaManager.GetAll();
            //cbMarka.DisplayMember = "Adi";
            //cbMarka.ValueMember = "Id";
        }
    }
}