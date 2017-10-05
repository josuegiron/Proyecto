using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Security.Cryptography;
using System.Text.RegularExpressions;

public static class Servicios
{
    public static string EncodePassword(string originalPassword)
    {
        //Clave que se utilizará para encriptar el usuario y la contraseña
        string clave = "7f9facc418f74439c5e9709832;0ab8a5:OCOdN5Wl,q8SLIQz8i|8agmu¬s13Q7ZXyno/";
        //Se instancia el objeto sha512 para posteriormente usarlo para calcular la matriz de bytes especificada
        SHA512 sha512 = new SHA512CryptoServiceProvider();

        //Se crea un arreglo llamada inputbytes donde se convierte el usuario, la contraseña y la clave a una secuencia de bytes.
        byte[] inputBytes = (new UnicodeEncoding()).GetBytes(originalPassword + clave);
        //Se calcula la matriz de bytes del arreglo anterior y se encripta.
        byte[] hash = sha512.ComputeHash(inputBytes);
        //Convertimos el arreglo de bytes a cadena.
        return Convert.ToBase64String(hash);
    }
    public static Boolean validarCorreo(String email)
    {
        String expresion;
        expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
        if (Regex.IsMatch(email, expresion))
        {
            if (Regex.Replace(email, expresion, String.Empty).Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}

