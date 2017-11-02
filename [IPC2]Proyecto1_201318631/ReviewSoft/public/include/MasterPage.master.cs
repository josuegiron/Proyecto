using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class publica_include_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

        if (!IsPostBack)
        {
            string userType = (string)Session["userType"];

            if (userType == "1")
            {
                string html = string.Format(@"
                    <ul>
                        <li><a href = 'index.html'> Home </a></li>
                        <li><a href = 'about.html'> About Us </a></li>
                        <li><a href = 'services.html'> Services </a></li>
                        <li><a href = 'gallery.html' > Gallery </a></li>
                        <li><a href = 'contact.html' class='current'> Salir </a></li>
                    </ul>
                ");

                this.literalMenu.Text = html;
            }
            else if (userType == "2")
            {
                string html = string.Format(@"
                    <ul>
                        <li>
                            <ul>
                                <li><a href = 'about.html'> About Us </a></li>
                                <li><a href = 'services.html'> Services </a></li>
                                <li><a href = 'gallery.html' > Gallery </a></li>
                            </ul>
                        </li>
                        <li><a href = 'about.html'> About Us </a></li>
                        <li><a href = 'services.html'> Services </a></li>
                        <li><a href = 'gallery.html' > Gallery </a></li>
                        <li><a href = 'contact.html' class='current'> Salir </a></li>
                    </ul>
                ");
            }
            else if (userType == "3")
            {
                string html = string.Format(@"

    <li><a href='index.aspx'>Inicio</a></li>
    <li><a href=# >Servicios</a>
      <ul class='subMenu'>
        <li><a href=''>Submenu1 fjfdj</a>
        
        <ul>
            <li><a href='#'>Submenu1</a></li>
            <li><a href='#'>Submenu2</a></li>
            <li><a href='#'>Submenu3</a></li>
            <li><a href='#'>Submenu4</a></li>
          </ul>
        </li>
        <li><a href='#'>Submenu2</a>
        
        <ul>
            <li><a href='#'>Submenu1</a>
            <ul>
            <li><a href='#'>Submenu1</a></li>
            <li><a href='#'>Submenu2</a></li>
          </ul>
            
            </li>
            <li><a href=''>Submenu2</a></li>
            <li><a href=''>Submenuddd</a></li>
            <li><a href=''>Submenu4</a></li>
          </ul></li>
        
        
        <li><a href=''>Submenu3</a></li>
        <li><a href=''>Submenu4</a>
          
        </li>
      </ul>
    </li>
    <li><a href=''>Acerca de</a>
      <ul class='subMenu'>
        <li><a href=''>Submenu1</a></li>
        <li><a href=''>Submenu2</a></li>
        <li><a href=''>Submenu3</a></li>
        <li><a href=''>Submenu4</a></li>
      </ul>
    </li>
    <li><a href='#'>Perfil</a>
        <ul class='subMenu'>
            <li><a href='#'>Mis Datos</a></li>
            <li><a href='#'>Submenu2</a></li>
            <li><a href='#'>Submenu3</a></li>
            <li><a href='salir.apx'>Salir</a></li>
        </ul>
    </li>

                ");
                this.literalMenu.Text = html;
            }
        }
    }
}