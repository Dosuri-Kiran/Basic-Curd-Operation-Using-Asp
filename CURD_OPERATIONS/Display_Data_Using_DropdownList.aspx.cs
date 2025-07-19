using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace CURD_OPERATIONS
{
    public partial class Display_Data_Using_DropdownList : System.Web.UI.Page
    {
        string constr=ConfigurationManager.ConnectionStrings["karthik"].ToString();
        SqlConnection con;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("select username from users",con);
            SqlDataReader dr=cmd.ExecuteReader();
            while (dr.Read())
            {
                if (Page.IsPostBack==false)
                {
                    DropDownList1.Items.Add(dr[0].ToString());
                }
            }
            cmd.Dispose();
            con.Close();

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con=new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("select *from users Where username='"+DropDownList1.Text+"'",con);
            SqlDataReader dr=cmd.ExecuteReader();
            dr.Read();
            TextBox1.Text = dr.GetString(1);
            TextBox2.Text = dr.GetString(2);
            TextBox3.Text = dr.GetInt64(3).ToString();
            cmd.Dispose();
            con.Close();
        }
    }
}