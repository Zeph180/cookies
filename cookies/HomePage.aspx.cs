using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cookies
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //check if username cookie is available
            if (Request.Cookies["UName"] != null)
            {
                usrName.InnerText = Request.Cookies["UName"].Value;
            }
            else
            {
                usrName.InnerText = "Guest";
            }

            //check if time of last visit exists
            if (Request.Cookies["LVisit"] != null)
            {
                lstVst.InnerText = Request.Cookies["LVisit"].Value;
            } 
            else
            {
                lstVst.InnerText = "Never visited";
            }

            if (!IsPostBack)
            {
                //set last visit  when user opens or closes the page
                HttpCookie cookie = new HttpCookie("LVisit");

                //Set cookie value
                cookie.Value = DateTime.Now.ToString();

                //make the cookie persistent
                cookie.Expires = DateTime.Now.AddDays(1);

                //push cookie to client computer
                Response.Cookies.Add(cookie);

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("UName");

            //setting cookie value to texbox input
            cookie.Value = nameInput.Text;

            //make the cookie persistent
            cookie.Expires = DateTime.Now.AddDays(1);
            //push cookie to client computer
            Response.Cookies.Add(cookie);

            usrName.InnerText = nameInput.Text;
        }
    }
}