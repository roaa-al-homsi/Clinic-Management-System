using ClinicSystem.MainMenu;
using ClinicSystemBusiness;
using System;
using System.Windows.Forms;

namespace ClinicSystem.Login
{
    public partial class frmMainLogin : Form
    {
        static public User CurrentUser = new User();
        public static DateTime DateLoginToSystem;
        public static DateTime DateLogoutFromSystem;
        private byte _CounterFailedLogin = 0;
        private short _CounterTick = 60;
        public frmMainLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            CurrentUser = User.FindByUserNameAndPassword(txtUsername.Text, txtPassword.Text);
            if (CurrentUser != null)
            {
                this.Hide();
                frmMainMenuScreen frmMainMenu = new frmMainMenuScreen();
                frmMainMenu.Show();
            }
            else
            {
                _CounterFailedLogin++;
                labCheckLogin.Visible = true;
                if (_CounterFailedLogin == 3)
                {
                    txtPassword.Enabled = false;
                    txtUsername.Enabled = false;
                    labCheckLogin.Text = $"System Lock, Wait a few seconds to log in again";
                    _CounterFailedLogin = 0;
                    timer1.Enabled = true;
                    labTimer.Visible = true;
                }
                else
                { labCheckLogin.Text = $"Invalid username or password, You have {3 - _CounterFailedLogin} tries to login"; }
                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
        }
        private void _Reset()
        {
            btnLogin.Enabled = true;
            timer1.Enabled = false;
            txtPassword.Enabled = true;
            txtUsername.Enabled = true;
            labTimer.Visible = false;
            labCheckLogin.Visible = false;
            _CounterTick = 60;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labTimer.Text = "00:" + _CounterTick.ToString();
            _CounterTick--;
            if (_CounterTick == 0)
            {
                _Reset();
            }
        }
    }
}
