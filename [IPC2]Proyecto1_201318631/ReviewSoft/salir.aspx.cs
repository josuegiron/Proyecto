using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class public_include_salir : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["userLogin"] = null;
        Session["userType"] = null;
        Response.Redirect("~/ingresar.aspx");
    }
}