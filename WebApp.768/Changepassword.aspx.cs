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
    public partial class Changepassword : System.Web.UI.Page

    {
        SqlConnection con = new SqlConnection("data source=RAHUL\\SQLEXPRESS;initial catalog=BB34_0980; integrated security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnchangepassword_Click(object sender, EventArgs e)
        {
            if (txtnewpassword.Text == txtconfirmnewpassword.Text)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update tblusers set upassword='" + txtnewpassword.Text + "' where uid= '" + Session["UIDD"] + "' and upassword='" + txtcrntpassword.Text + "'", con);
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (i == 0)
                {

                    lblmsg.Text = "your current Password is not correct";
                }
                else
                {
                    lblmsg.Text = "your password has been changed successfully !!";
                }

            }
            else
            {
                lblmsg.Text = "password do not match !!";
            
            }

        }


    }
}