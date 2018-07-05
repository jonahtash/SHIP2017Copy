using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace SHIPSite
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SearchText.Attributes.Add("onkeyup", "button_click(this,'" + this.Submit.ClientID + "')");
            if (SearchText.Text.Equals("Search...") || SearchText.Text.Equals(""))
            {
                Submit.Enabled = false;
            }
        }
        protected void Submit_Click(object sender, EventArgs e)
        {
           string q = String.Join(" ",SearchText.Text.Replace("(", "").Replace(")", "").Split(' ').Take(15));

            Response.Redirect("~/Search.aspx?q=" + q);
        }
    }
}