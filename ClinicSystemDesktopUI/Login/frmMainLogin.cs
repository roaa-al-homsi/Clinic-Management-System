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
        public frmMainLogin()
        {
            InitializeComponent();
        }
    }
}
