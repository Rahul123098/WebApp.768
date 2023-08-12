using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.Eventing.Reader;

namespace WebApp._768
{
    public partial class UserRegistrationform : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("data source=RAHUL\\SQLEXPRESS;initial catalog=BB34_0980; integrated security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bindtblcountry();
                BindGender();
                BindQualification();
                ddlstate.Items.Insert(0, new ListItem("--Select--", "0"));
                ddlstate.Enabled = false;
                ddlcity.Items.Insert(0, new ListItem("--Select--", "0"));
                ddlcity.Enabled = false;

            }



            if (Request.QueryString["pp"] != null && Request.QueryString["pp"].ToString() != "")

            {
                if (!IsPostBack)
                {
                    Edit();

                }
            }


        }

        public void Edit()
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("Users_Edit", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@uid", Request.QueryString["pp"]);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            txtname.Text = dt.Rows[0]["uname"].ToString();
            rblgender.SelectedValue = dt.Rows[0]["ugender"].ToString();
            txtemail.Text = dt.Rows[0]["uemail"].ToString();
            txtpassword.Text = dt.Rows[0]["upassword"].ToString();
            ddlqualification.SelectedValue = dt.Rows[0]["uqualification"].ToString();
            rblcountry.SelectedValue = dt.Rows[0]["ucountry"].ToString();
            Bindtblstate();
            ddlstate.SelectedValue = dt.Rows[0]["ustate"].ToString();
            Bindtblcity();
            ddlcity.SelectedValue = dt.Rows[0]["ucity"].ToString();

            btnsubmit.Text = "Update";









        }




        public void BindGender()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Gender_Get", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            rblgender.DataValueField = "gid";
            rblgender.DataTextField = "gname";
            rblgender.DataSource = dt;
            rblgender.DataBind();



        }



        public void BindQualification()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Qualification_Get", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            ddlqualification.DataValueField = "qid";
            ddlqualification.DataTextField = "qname";
            ddlqualification.DataSource = dt;
            ddlqualification.DataBind();
            ddlqualification.Items.Insert(0, new ListItem("--Select--", "0"));


        }


        public void Bindtblcountry()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblcountry", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            rblcountry.DataValueField = "Cid";
            rblcountry.DataTextField = "Cname";
            rblcountry.DataSource = dt;
            rblcountry.DataBind();
           // rblcountry.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        public void Bindtblstate()
            
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblstate where Cid='"+rblcountry.SelectedValue+"'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            ddlstate.DataValueField = "sid";
            ddlstate.DataTextField = "sname";
            ddlstate.DataSource = dt;
            ddlstate.DataBind();
            ddlstate.Enabled = true;

            ddlstate.Items.Insert(0, new ListItem("--Select--", "0"));
        }


        public void Bindtblcity()

        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblcity where sid='" + ddlstate.SelectedValue + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            ddlcity.DataValueField = "cityid";
            ddlcity.DataTextField = "cityname";
            ddlcity.DataSource = dt;
            ddlcity.DataBind();
            ddlcity.Enabled = true;

            ddlcity.Items.Insert(0, new ListItem("--Select--", "0"));
        }





        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            if (btnsubmit.Text == "submit")

            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Users_Insert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@uname",txtname.Text);
                cmd.Parameters.AddWithValue("@ugender", rblgender.SelectedValue);
                cmd.Parameters.AddWithValue("@uemail", txtemail.Text);
                cmd.Parameters.AddWithValue("@upassword", txtpassword.Text);
                cmd.Parameters.AddWithValue("@uqualification", ddlqualification.SelectedValue);
                cmd.Parameters.AddWithValue("@ucountry", rblcountry.SelectedValue);
                cmd.Parameters.AddWithValue("@ustate", ddlstate.SelectedValue);
                cmd.Parameters.AddWithValue("@ucity", ddlcity.SelectedValue);


                cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("UserShow.aspx");
            }

            else if (btnsubmit.Text == "Update")

            {

                con.Open();
                SqlCommand cmd = new SqlCommand("Users_Update", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@uid", Request.QueryString["pp"]);
                cmd.Parameters.AddWithValue("@uname", txtname.Text);
                cmd.Parameters.AddWithValue("@ugender", rblgender.SelectedValue);
                cmd.Parameters.AddWithValue("@uemail", txtemail.Text);
                cmd.Parameters.AddWithValue("@upassword", txtpassword.Text);
                cmd.Parameters.AddWithValue("@uqualification", ddlqualification.SelectedValue);
                cmd.Parameters.AddWithValue("@ucountry", rblcountry.SelectedValue);
                cmd.Parameters.AddWithValue("@ustate", ddlstate.SelectedValue);
                cmd.Parameters.AddWithValue("@ucity", ddlcity.SelectedValue);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("UserShow.aspx");







            }





        }

        protected void rblcountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rblcountry.SelectedValue == "0")
            {
                ddlstate.Enabled = false;

            }
            else
            {
                Bindtblstate();
            }
        }

        protected void ddlstate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlstate.SelectedValue == "0")
            {
                ddlcity.Enabled = false;

            }
            else
            {
                Bindtblcity();
            }



        }
    }




}