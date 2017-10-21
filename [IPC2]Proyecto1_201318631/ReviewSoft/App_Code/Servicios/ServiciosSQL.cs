using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public static class ServiciosSQL
{
    public static bool Autenticar(string usuario, string password)
    {
        //Declaramos la sentencia SQL
        string sql = @"SELECT COUNT(*)
                       FROM Usuario
                       WHERE usuario = @usuario AND password = @password";

        //utilizamos using para indicarle al compilador que dentro de este bloque se llame al Método Dispose.
        //para así liberar recursos cuanto antes mejor. en este caso no ocupamos decirle que cierre la conexión a la base de datos.
        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cadenaConexion"].ToString()))
        {
            conn.Open();

            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("@usuario", usuario);
            string hash = Servicios.EncodePassword(string.Concat(usuario, password));
            command.Parameters.AddWithValue("@password", hash);

            int count = Convert.ToInt32(command.ExecuteScalar());
            
            if (count == 0)
                return false;
            else
                return true;

        }
    }
    public static void Security(int userid, string usuario, DateTime ultimoacc, string ip)
    {
        string sql = @"INSERT INTO UsuarioSecurity(
                            UsuarioID
                           ,Username
                           ,UltimoAcceso
                           ,IPAcceso)
                        VALUES(
                            @UsuarioID,
                            @Username,
                            @UltimoAcceso,
                            @IPAcceso)
                            SELECT SCOPE_IDENTITY()";
        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cadenaConexion"].ToString()))
        {
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("@UsuarioID", userid);
            command.Parameters.AddWithValue("@Username", usuario);
            command.Parameters.AddWithValue("@UltimoAcceso", ultimoacc);
            command.Parameters.AddWithValue("@IPAcceso", ip);

            conn.Open();

            int resultado = Convert.ToInt32(command.ExecuteScalar());
        }
    }
    public static DataTable prConsultaUsuario(string usuario, string password)
    {
        string sql = @"SELECT num_usuario, id_rol
                            FROM Usuario
                            WHERE usuario = @Username AND password = @password";


        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cadenaConexion"].ToString()))
        {
            SqlCommand command = new SqlCommand(sql, conn);

            command.Parameters.AddWithValue("@Username", usuario);
            string hash = Servicios.EncodePassword(string.Concat(usuario, password));
            command.Parameters.AddWithValue("@password", hash);

            conn.Open();
            SqlDataAdapter daAdaptador = new SqlDataAdapter(command);
            DataTable dtDatos = new DataTable();
            daAdaptador.Fill(dtDatos);
            return dtDatos;
        }

    }
    public static void registrarUsuario(string usuario, string password, string nombre, string apellido, string fecha_nac, string correo, string profesion, int id_rol)
    {
        string sql = @"INSERT INTO Usuario(usuario, password, nombre, apellido, fecha_nac, correo, profesion, id_rol) VALUES (@usuario, @password, @nombre, @apellido, @fecha_nac, @correo,  @profesion,  @id_rol);";
        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cadenaConexion"].ToString()))
        {
           
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@usuario", usuario);
                string passwordEncode = Servicios.EncodePassword(string.Concat(usuario, password));
                command.Parameters.AddWithValue("@password", passwordEncode);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@fecha_nac", Convert.ToDateTime(fecha_nac));
                command.Parameters.AddWithValue("@correo", correo);
                command.Parameters.AddWithValue("@profesion", profesion);
                command.Parameters.AddWithValue("@id_rol", id_rol);

                conn.Open();

                int resultado = Convert.ToInt32(command.ExecuteScalar());
           
        }
    }
    public static Boolean verificarUsuario(string usuario)
    {
        string sql = @"SELECT * FROM Usuario WHERE usuario = @usuario";
        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cadenaConexion"].ToString()))
        {
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("@usuario", usuario);

            conn.Open();
            SqlDataAdapter daAdaptador = new SqlDataAdapter(command);
            
            DataTable tblUsuario = new DataTable();
            daAdaptador.Fill(tblUsuario);

            if (tblUsuario.Rows.Count==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }

}


