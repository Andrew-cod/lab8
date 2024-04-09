using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlCommand cmd;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                try
                {
                    ConexiuneBD.conn.Open();
                    cmd = new SqlCommand("select NumeUtilizator from Users", ConexiuneBD.conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        DropDownList1.Items.Add(dr[0].ToString());
                    }
                }
                catch (Exception ex)
                {
                    Label1.Text = "Nu se poate realiza conexiunea " + ex.Message;
                }
                finally
                {
                    ConexiuneBD.conn.Close();
                }
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConexiuneBD.conn.Open();
                cmd = new SqlCommand("select Parola from Users where NumeUtilizator='" + DropDownList1.Text + "'", ConexiuneBD.conn);
                dr = cmd.ExecuteReader();
                if (!dr.Read())
                {
                    Label1.Text = "Datele sunt gresite!";
                }
                else
                {
                    string url;
                    if (dr[0].ToString().Trim() == TextBox1.Text.Trim())
                    {
                        Application["numeUser"] = DropDownList1.Text;
                        url = "WebForm3.aspx";
                        Response.Redirect(url);
                    }
                    else
                    {
                        Label1.Text = "Parola gresita!";
                    }
                }
            }
            catch (Exception ex)
            {
                Label1.Text = "Nu se poate realiza conexiunea " + ex.Message;
            }
            finally
            {
                ConexiuneBD.conn.Close();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //deschidem forma de înregistrare
            Response.Redirect("WebForm2.aspx");

        }
    }
}
