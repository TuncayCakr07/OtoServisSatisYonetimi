﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OtoServisWepUI
{
    public partial class OtoServisSablon : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session ["Admin"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}