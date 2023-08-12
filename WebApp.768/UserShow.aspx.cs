using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Linq;

namespace WebApp._768
{
    public partial class UserShow : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("data source=RAHUL\\SQLEXPRESS;initial catalog=BB34_0980; integrated security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
                

            }




        }

        public void BindGrid()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("User_Join", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            
            gvusers.DataSource = dt;
            gvusers.DataBind();



        }

        protected void gvusers_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "A")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("User_Delete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@uid", e.CommandArgument);
                cmd.ExecuteNonQuery();
                con.Close();
                BindGrid();


            }

            else if (e.CommandName == "B")
            {

                Response.Redirect("UserRegistrationform.aspx?pp=" + e.CommandArgument);
            
            }



        }

        protected void gvusers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("Users_Search", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Search", txtsearch.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                gvusers.DataSource = dt;
                gvusers.DataBind();
                lblmsg.Text = "These are your results !!";
            }
            else
              
            {
                gvusers.DataSource = null;
                gvusers.DataBind();
                lblmsg.Text = "No record found !!";
                          
            }


        }
    }
}