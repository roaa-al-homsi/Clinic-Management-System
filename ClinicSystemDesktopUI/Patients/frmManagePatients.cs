using ClinicSystem.MainMenu;
using ClinicSystemBusiness;
using System;
using System.Windows.Forms;

namespace ClinicSystem.Patients
{
    public partial class frmManagePatients : Form
    {
        private frmMainMenuScreen _frmMainMenu;
        public frmManagePatients(frmMainMenuScreen frmMainMenu)
        {
            InitializeComponent();
            _frmMainMenu = frmMainMenu;
        }
        private void _RefreshPatientsData()
        {
            dgvManagePatients.DataSource = Patient.All();
        }
        private void frmManagePatients_Load(object sender, EventArgs e)
        {
            _RefreshPatientsData();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            _frmMainMenu.OpenChildFormAsync(new frmAddUpdatePatient(-1));
        }
    }
}
