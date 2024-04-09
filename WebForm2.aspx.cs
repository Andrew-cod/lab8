using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab8
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;

            try
            {
                ConexiuneBD.conn.Open();
                cmd = new SqlCommand("insert into Users (NumeUtilizator,Parola) values(@nume,@pass) ",
                ConexiuneBD.conn);
                cmd.Parameters.AddWithValue("@nume", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@pass",TextBox2.Text.Trim());
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 1)
                {
                    string url = "WebForm1.aspx";
                    Response.Redirect(url);
                }
                else
                    Label1.Text = "Eroare inserare!";
            }
            catch (Exception ex)
            {
                //log error 
                Label1.Text = "Eroare la deschidere baza date " + ex.Message;
            }
            //adaugarea datelor
            finally
            {
                ConexiuneBD.conn.Close();
            }
        }

    }
}