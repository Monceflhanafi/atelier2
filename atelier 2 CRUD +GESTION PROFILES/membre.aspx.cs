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
    public partial class membre : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            afficher();

            divedi.Visible = false;
        }
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-M86HAUC\SQLEXPRESS02;Initial Catalog=Atelier2;Integrated Security=True");
        SqlCommand cmd;


        private void afficher()
        {
            try
            {

                cnx.Open();
                cmd = new SqlCommand("select*from Membres", cnx);

                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
                cnx.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
        }
        protected void Ajouter_Click(object sender, EventArgs e)
        {
            
            cnx.Open();
            cmd = new SqlCommand("insert into Membres values(@loginn,@motpass,@Cmotpass,@email,@nom,@dateNaissance)", cnx);
            cmd.Parameters.AddWithValue("@loginn", logTX.Text);
            cmd.Parameters.AddWithValue("@motpass", MpassTX.Text);
            cmd.Parameters.AddWithValue("@Cmotpass", CMpassTX.Text);
            cmd.Parameters.AddWithValue("@email", emailTX.Text);
            cmd.Parameters.AddWithValue("@nom", nomTX.Text);
            cmd.Parameters.AddWithValue("@dateNaissance", dateTX.Text);
            cmd.ExecuteNonQuery();
            cnx.Close();
            afficher();
            divedi.Visible = true;
        }

        protected void modifier_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("update Membres set motpass=@motpass,Cmotpass=@Cmotpass,email=@email,nom=@nom,dateNaissance=@dateNaissance where loginn=@loginn", cnx);
            cmd.Parameters.AddWithValue("@loginn", logTX.Text);
            cmd.Parameters.AddWithValue("@motpass", MpassTX.Text);
            cmd.Parameters.AddWithValue("@Cmotpass", CMpassTX.Text);
            cmd.Parameters.AddWithValue("@email", emailTX.Text);
            cmd.Parameters.AddWithValue("@nom", nomTX.Text);
            cmd.Parameters.AddWithValue("@dateNaissance", dateTX.Text);
            cmd.ExecuteNonQuery();
            cnx.Close();
            afficher();
            divedi.Visible = true;
        }

        protected void supprimer_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("delete from Membres where loginn=@loginn", cnx);
            cmd.Parameters.AddWithValue("@loginn", logTX.Text);
            cmd.ExecuteNonQuery();
            cnx.Close();
            afficher();
            divedi.Visible = true;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/index.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            divedi.Visible = true;
        }
    }
}