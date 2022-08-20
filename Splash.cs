namespace Splash
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(2);
            Opacity -= 0.010;
            nroDeCarga.Text = progressBar1.Value.ToString() + "%";

            if (progressBar1.Value == progressBar1.Maximum)
            {
                Tiempo.Stop();
                this.Hide();
                Login l = new Login();
                l.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}