using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Registro : System.Web.UI.Page
{
    

    protected void Page_Load(object sender, EventArgs e)
    {
       

    }
    protected void btnRegistrar_Click(object sender, EventArgs e)
    {
        string usuario = this.txtUsuario.Text.Replace(";", "").Replace("--", "");
        string password = this.txtContraseña.Text.Replace(";", "").Replace("--", "");
        string nombre = this.txtNombre.Text.Replace(";", "").Replace("--", "");
        string apellido = this.txtApellido.Text.Replace(";", "").Replace("--", "");
        string fecha_nac = this.selFecha.Text.Replace(";", "").Replace("--", "");
        string correo = this.txtCorreo.Text.Replace(";", "").Replace("--", "");
        string profesion = this.txtProfesion.Text.Replace(";", "").Replace("--", "");
        

        if (!ServiciosSQL.verificarUsuario(usuario))
        {
            int ejecutar = 0;

            if (usuario != "") { ejecutar++; errorUsuario.Text = ""; } else { errorUsuario.Text = "Ingresar un usuario "; }
            if (password != "") { ejecutar++; errorPassword.Text = ""; } else { errorPassword.Text = "Ingresar un password "; }
            if (nombre != "") { ejecutar++; errorNombre.Text = ""; } else { errorNombre.Text = "Ingrese su nombre "; }
            if (apellido != "") { ejecutar++; errorApellido.Text = ""; } else { errorApellido.Text = "Ingrese su apellido "; }
            if (fecha_nac != "") { ejecutar++; errorFechaNac.Text = ""; } else { errorFechaNac.Text = "Ingrese su fecha de nacimiento "; }
            if (Servicios.validarCorreo(correo)) { ejecutar++; errorCorreo.Text = ""; } else { errorCorreo.Text = "Ingresar un correo valido "; }
            if (profesion != "") { ejecutar++; errorProfesion.Text = ""; } else { errorProfesion.Text = "Ingrese su profesion actual "; }

            if (ejecutar == 7)
            {
                ServiciosSQL.registrarUsuario(usuario, password, nombre, apellido, fecha_nac, correo, profesion, 1);
            }
        }
        else
        {
            errorUsuario.Text = "Usuario \""+usuario+"\" ya ha sido registrado";
        }
    }

     
    protected void selFecha_Click(object sender, EventArgs e)
    {
        Calendar1.Visible = true;
        
       
    }


    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        selFecha.Text = Calendar1.SelectedDate.ToShortDateString();
        Calendar1.Visible = false;
    }
}

   
