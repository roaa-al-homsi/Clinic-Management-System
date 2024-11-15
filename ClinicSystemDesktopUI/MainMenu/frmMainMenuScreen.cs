using ClinicSystem.Doctors;
using ClinicSystem.Employees;
using Guna.UI2.WinForms;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicSystem.MainMenu
{
    public partial class frmMainMenuScreen : Form
    {
        public frmMainMenuScreen()
        {
            InitializeComponent();
        }

        private Guna2Button _currentButton;
        private Form _activeForm;
        private void _ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (_currentButton != null)
                {
                    _currentButton.BackColor = Color.FromArgb(175, 238, 238);
                    _currentButton.ForeColor = Color.White;
                    _currentButton.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }

                _currentButton = (Guna2Button)btnSender;
                _currentButton.BackColor = Color.White;
                _currentButton.ForeColor = Color.FromArgb(175, 238, 238);
                _currentButton.Font = new System.Drawing.Font("Comic Sans MS", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        public void OpenChildFormAsync(Form childForm, object btnSender)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }
            _ActivateButton(btnSender);
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMainMenu.Controls.Add(childForm);
            panelMainMenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            if (childForm.Tag != null)
            {
                btnTitle.Text = childForm.Tag.ToString();
            }
            else
            {
                btnTitle.Text = childForm.Text;
            }
        }
        public void OpenChildFormAsync(Form childForm)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMainMenu.Controls.Add(childForm);
            panelMainMenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            if (childForm.Tag != null)
            {
                btnTitle.Text = childForm.Tag.ToString();
            }
            else
            {
                btnTitle.Text = childForm.Text;
            }
        }
        private void _MessageAccessDenied()
        {
            MessageBox.Show("Access Denied!! You don't have permission to use this feature." +
                     "Please contact your administrator for assistance..", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        private void btnEmployees_Click_1(object sender, System.EventArgs e)
        {
            btnTitle.Image = btnEmployees.Image;
            OpenChildFormAsync(new frmManageEmployees(this), sender);
        }
        private void frmMainMenuScreen_Load(object sender, System.EventArgs e)
        {

        }

        private void btnDoctors_Click(object sender, System.EventArgs e)
        {

            btnTitle.Image = btnDoctors.Image;
            OpenChildFormAsync(new frmManageDoctorcs(this), sender);
        }
    }
}
