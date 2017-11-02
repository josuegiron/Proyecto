using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class public_principal_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string userLogin = (string)Session["userLogin"];
        string userType = (string)Session["userType"];

        if (!IsPostBack)
        {
            if(userLogin == "" || userLogin == null)
            {
                Response.Redirect("~/Ingresar.aspx");
            }
        }

    }
}