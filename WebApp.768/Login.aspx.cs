using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApp._768
{
    public partial class Login : System.Web.UI.Page

    {

        SqlConnection con = new SqlConnection("data source=RAHUL\\SQLEXPRESS;initial catalog=BB34_0980; integrated security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblusers where uemail= '"+txtemail.Text+"' and upassword= '"+txtpassword.Text+"'",con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                Session["UIDD"] = dt.Rows[0]["uid"];
                Response.Redirect("Home.aspx");

            }

            else
            {
                lblmsg.Text = "Login Failed !!";
            
            }


        }
    }
}