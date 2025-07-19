using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CURD_OPERATIONS
{
    public partial class CURD_OPERATION_WebForm1 : System.Web.UI.Page
    {
        string getcon = ConfigurationManager.ConnectionStrings["karthik"].ToString();
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void Button1_Click(object sender, EventArgs e)
        {
            // Check for empty fields
            if (string.IsNullOrWhiteSpace(TextBox1.Text) ||
                string.IsNullOrWhiteSpace(TextBox2.Text) ||
                string.IsNullOrWhiteSpace(TextBox3.Text) ||
                string.IsNullOrWhiteSpace(TextBox4.Text))
            {
                Label5.Text = "All fields are required.";
                Label5.ForeColor = System.Drawing.Color.Red;
                return; // Stop execution
            }

            try
            {
                con = new SqlConnection(getcon);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_add", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", TextBox1.Text);
                cmd.Parameters.AddWithValue("@pwd", TextBox2.Text);
                cmd.Parameters.AddWithValue("@email", TextBox3.Text);
                cmd.Parameters.AddWithValue("@phone", TextBox4.Text);
                cmd.ExecuteNonQuery();
                Label5.Text = "Record Saved Successfully";
                Label5.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                Label5.Text = ex.Message;
                Label5.ForeColor = System.Drawing.Color.Red;
            }
            finally
            {
                con.Close();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(getcon);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_view", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", TextBox1.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                TextBox2.Text = dr.GetString(1);
                TextBox3.Text = dr.GetString(2);
                TextBox4.Text = dr.GetInt64(3).ToString(); // because of the data type is bigint
                cmd.Dispose();
                
            }
            catch (Exception ex1)
            {
                Label5.Text= ex1.Message;
                Label5.ForeColor = System.Drawing.Color.Red;
            }
            finally { con.Close(); }
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            // Check for empty fields
            if (string.IsNullOrWhiteSpace(TextBox1.Text) ||
               // string.IsNullOrWhiteSpace(TextBox2.Text) ||
                string.IsNullOrWhiteSpace(TextBox3.Text) ||
                string.IsNullOrWhiteSpace(TextBox4.Text))
            {
                Label5.Text = "All fields are required.";
                Label5.ForeColor = System.Drawing.Color.Red;
                return; // Stop execution
            }
            try
            {
                con = new SqlConnection(getcon);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_update", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", TextBox1.Text);
                cmd.Parameters.AddWithValue("@pwd", TextBox2.Text);
                cmd.Parameters.AddWithValue("@email", TextBox3.Text);
                cmd.Parameters.AddWithValue("@phone", TextBox4.Text);
                cmd.ExecuteNonQuery();
               
                Label5.Text = "RECORD UPDATED SUCCESSFULLY";
                Label5.ForeColor=System.Drawing.Color.Brown;
            }
            catch(Exception ex2)
            {
                Label5.Text= ex2.Message;
            }
            finally { con.Close(); }
        
        }
        protected void Button4_Click(object sender,EventArgs e)
        {
            try
            {
                con = new SqlConnection(getcon);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_delete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", TextBox1.Text);
                cmd.ExecuteNonQuery();
                Label5.Text = "RECORD DELETED SUCCESSFULLY";
                Label5.ForeColor = System.Drawing.Color.Blue;
            }
            catch(Exception ex3)
            {
                Label5.Text= ex3.Message;
            }
            finally { con.Close(); }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            Label5.Text = "";
        }
    }
}