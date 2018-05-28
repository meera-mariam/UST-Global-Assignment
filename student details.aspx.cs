using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace UST_Global
{
    public partial class student_details : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = @"Data Source=DESKTOP-VHODRQT\SQLSERVER;Initial Catalog=organicdb;User ID=sa;Password=admin123";
            conn.Open();

        }

        protected void Btnadd_Click(object sender, EventArgs e)
        {
                        string ins = "insert into student_tbl(Sname,Sregid,Address,[Batch No],Contact)values('" + txtname.Text.Trim() + "','" + txtregid.Text.Trim() + "','" + txtbatchno.Text.Trim() + "','" + txtcontact.Text.Trim() + "',)";
            SqlCommand cmd = new SqlCommand(ins, conn);

            cmd.ExecuteNonQuery();
            txtsname.Text = "";
            txtregid.Text = "";
            txtbatchno.Text = "";
            txtemail.Text = "";
            txtcontact.Text = "";


            Response.Write("<script LANGUAGE='Javascript'>alert('Details Added Successfully')</script");
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
             String update = "update student_tbl set Sname='" + txtname.Text + "',Address='" + txtaddress.Text + "',Email='" + txtemail.Text + "',Contact='" + txtcontact.Text + "';
            SqlCommand cmd = new SqlCommand(update, conn);
            cmd.ExecuteNonQuery();


            Response.Write("<script LANGUAGE='JavaScript' >alert('Supplier Updated Successfully')</script>");
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            String delete = ("delete from student_tbl  where [Sname]=('" + txtnamee.Text + "' )");
            SqlCommand cmd = new SqlCommand(delete, conn);
            cmd.ExecuteNonQuery();
            Response.Write("<script LANGUAGE='JavaScript' >alert('Student Deleted Successfully')</script>");
        }




    }
}

      