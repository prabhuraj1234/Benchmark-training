using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if(txtLogin.Text=="")
        {
            lblerr.Text = "Please Enter login Name";
        }

        else if(txtPass.Text=="")
        {
            lblerrPass.Text = "Please enter coreect password";
        }

        else
        {
            string Login = txtLogin.Text;
            string pass = txtPass.Text;
            if(Login=="admin"&& pass=="pass@123")
            {
                Response.Redirect("firstform.aspx");
            }
            else
            {
                Lblerr2.Text = "Invalid usename or Password";
            }
        }
    }
}