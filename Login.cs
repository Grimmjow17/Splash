using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splash
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        SqlConnection ConnectionDB = new SqlConnection(@"Data Source=(JAEGER); Initial Catalog=Sellpoint; Integrated Security=true");
    
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbPassword_TextChanged(object sender, EventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnIngresar_Click(sender, e);
            }
        }
        

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtbUserName.Text == "" || txtbPassword.Text == "")
            {
                MessageBox.Show("Porfavor, complete ambos campos");
            }

            else
            {
                clsBeEntidades em = new clsBeEntidades();
                clsLnEntidades clsLnEntidades = new clsLnEntidades();

                em.UserNameEntidad = txtbUserName.Text;
                em.PasswordEntidad = txtbPassword.Text;

                if (clsLnEntidades.Obtener(ref em))
                {

                    Program.validatelogin = true;
                    Program.Username = txtbUsername.Text;
                    this.Dispose();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Su usuario o clave son incorrectos.", "Datos incorrectos.", MessageBoxButtons.OK);
                }

            }
        }
    }
}


///StringConnectionDB.Open();
///SqlCommand comando = new SqlCommand("SELECT UserNameEntidad, PasswordEntidad FROM Entidades WHERE UserNameEntidad = @vUsernameEntidad AND PasswordEntidad = @vPasswordEntidad", StringConnectionDB);
///comando.Parameters.AddWithValue("@vUserNameEntidad", txtbUserName);
///comando.Parameters.AddWithValue("@vPasswordEntidad", txtbPassword);

///SqlDataReader lector = comando.ExecuteReader();

///if (lector.Read())
///{
  ///  StringConnectionDB.Close();
    ///Menu menu = new Menu();
    ///menu.Show();
///}