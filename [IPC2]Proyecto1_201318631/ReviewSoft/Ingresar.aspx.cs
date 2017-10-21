using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Ingresar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnIniciar_Click(object sender, EventArgs e)
    {
        string usuario = this.txtUsuario.Text.Replace(";", "").Replace("--", "");
        string contraseña = this.txtContraseña.Text.Replace(";", "").Replace("--", "");
        if (ServiciosSQL.Autenticar(usuario, contraseña))
        {
            DataTable tblUsuario = ServiciosSQL.prConsultaUsuario(usuario, contraseña);
            //LoginService.Security(Convert.ToInt32(tblUsuario.Rows[0]["usuario"]), usuario, DateTime.Now, Request.ServerVariables["REMOTE_ADDR"]);
            Session["userLogin"] = tblUsuario.Rows[0]["num_usuario"].ToString();
            Session["userType"] = tblUsuario.Rows[0]["id_rol"].ToString();

            Response.Redirect("~/public/principal/index.aspx");
        }
        else
        {
            //Mensaje de error en caso de no ser usuario registrado
            lblMensaje.Text = "Usuario o contraseña incorrecta, verifique por favor.";
        }
    }
   
}