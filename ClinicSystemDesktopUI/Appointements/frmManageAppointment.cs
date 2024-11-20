using ClinicSystem.Appointments;
using ClinicSystem.MainMenu;
using ClinicSystemBusiness;
using System;
using System.Windows.Forms;

namespace ClinicSystem.Appointments
{
    public partial class frmManageAppointment : Form
    {
        private frmMainMenuScreen _frmMainMenuScreen;
        public frmManageAppointment(frmMainMenuScreen frmMainMenu)
        {
            InitializeComponent();
            _frmMainMenuScreen = frmMainMenu;
        }
        private void _RefreshAppointmentData()
        {
            dgvManageAppointement.DataSource = Appointment.All();
        }
        private void frmManageAppointment_Load(object sender, EventArgs e)
        {
            _RefreshAppointmentData();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            _frmMainMenuScreen.OpenChildFormAsync(new frmAddUpdateAppointment());
        }
    }
}
