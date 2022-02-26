using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace atelier_2_CRUD__GESTION_PROFILES
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-M86HAUC\SQLEXPRESS02;Initial Catalog=Atelier2;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        protected void createACC_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/inscription.aspx");
        }

        protected void connect_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("select loginn, motpass from Membres where loginn= @loginn and motpass=@motpass", cnx);
            cmd.Parameters.AddWithValue("@loginn", loginTX.Text);
            cmd.Parameters.AddWithValue("@motpass", passTX.Text);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr[0].ToString() == loginTX.Text && dr[1].ToString() == passTX.Text)
                {
                    Response.Redirect("~/membre.aspx");
                }
            }
            
            else
            {
                MessageBox.Show("wrong password"); 
            }
            cnx.Close();
        }
    }
}