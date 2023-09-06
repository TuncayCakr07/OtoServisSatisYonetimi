using System;

namespace OtoServisWepUI
{
    public partial class Menu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbCikis_Click(object sender, EventArgs e)
        {
            if (Session["Admin"] != null)
            {
                Session.Remove("Admin");
                Response.Redirect("/Login.aspx");
            }
        }
    }
}