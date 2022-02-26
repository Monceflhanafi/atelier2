using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace atelier_2_CRUD__GESTION_PROFILES
{
    public partial class inscription : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
       
        
        protected void inscrire_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-M86HAUC\SQLEXPRESS02;Initial Catalog=Atelier2;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;
            
            
            //pour avoir est ce que le mot de passe est superieur a 6 et egale le chmaps de confirmation
            if (MpassTX.Text.Length>=6 && MpassTX.Text== CMpassTX.Text)
            {cnx.Open();
                cmd = new SqlCommand("insert into Membres values(@loginn,@motpass,@Cmotpass,@email,@nom,@dateNaissance)", cnx);
                cmd.Parameters.AddWithValue("@loginn", logTX.Text);
                cmd.Parameters.AddWithValue("@motpass", MpassTX.Text);
                cmd.Parameters.AddWithValue("@Cmotpass", CMpassTX.Text);
                cmd.Parameters.AddWithValue("@email", emailTX.Text);
                cmd.Parameters.AddWithValue("@nom", nomTX.Text);
                cmd.Parameters.AddWithValue("@dateNaissance", dateTX.Text);
                cmd.ExecuteNonQuery();
cnx.Close();
                Response.Redirect("~/membre.aspx");
            }
           
        }
    }
}