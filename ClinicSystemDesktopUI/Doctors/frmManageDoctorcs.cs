using ClinicSystem.MainMenu;
using ClinicSystemBusiness;
using System;
using System.Windows.Forms;

namespace ClinicSystem.Doctors
{
    public partial class frmManageDoctorcs : Form
    {
        private frmMainMenuScreen _frmMainMenuScreen;
        public frmManageDoctorcs(frmMainMenuScreen frmMainMenu)
        {
            InitializeComponent();
            _frmMainMenuScreen = frmMainMenu;
        }
        private void _RefreshDoctorsData()
        {
            dgvManageDoctors.DataSource = Doctor.All();
        }
        private void frmManageDoctorcs_Load(object sender, EventArgs e)
        {
            _RefreshDoctorsData();
        }
        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            _frmMainMenuScreen.OpenChildFormAsync(new frmAddUpdateDoctor(-1));

        }
    }
}
