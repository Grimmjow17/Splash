using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splash

{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();       
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void opcionAcercade_Click(object sender, EventArgs e)
        {
            Acercade acercade = new Acercade();
            acercade.ShowDialog();

        }

        private void opcionLogin_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.ShowDialog();
        }
    }
}
