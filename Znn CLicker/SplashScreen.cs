using System;
using System.Windows.Forms;

namespace Znn_CLicker
{
    public partial class SplashScreen : Form
    {
        private Home _frm_Home = new Home();

        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            txt_Name.Text = Home.NAME;
            progress_Load.Value = 1;
            _frm_Home.Show();

            if (Settings.Default.showSplashScreen)
                _frm_Home.Hide();
        }

        private void timer_LoadTime_Tick(object sender, EventArgs e)
        {
            progress_Load.Value += 1;
            progress_Load.Text = $"{progress_Load.Value}%";
            if (progress_Load.Value == 100)
            {
                this.Hide();
                _frm_Home.Show();
                timer_LoadTime.Stop();
            }
        }
    }
}
