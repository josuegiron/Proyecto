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
          <nav role=navigation>
  
<ul class=nav>
  <li><a href=>Home</a></li>
  <li><a href= class=has-submenu>Submenu</a>
    <ul class=submenu>
      <li><a href=>Submenu item</a></li>
      <li><a href=>Submenu item</a></li>
      <li><a href=>Submenu item</a></li>
      <li><a href=>Submenu item</a></li>
    </ul>
  </li>  
  <li><a href= class=has-submenu>Submenu</a>
    <ul class=submenu>
      <li><a href=>Submenu item</a></li>
      <li><a href=>Submenu item</a></li>
      <li><a href=>Submenu item</a></li>
      <li><a href=>Submenu item</a></li>
    </ul>
  </li>
  <li><a href=>About us</a></li>
</ul>
  
</nav>

                ");
                this.literalMenu.Text = html;
            }
        }
    }
}