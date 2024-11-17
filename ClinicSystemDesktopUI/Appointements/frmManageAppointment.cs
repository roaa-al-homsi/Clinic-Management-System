using ClinicSystemBusiness;
using System;
using System.Windows.Forms;

namespace ClinicSystem.Appointments
{
    public partial class frmManageAppointment : Form
    {
        public frmManageAppointment()
        {
            InitializeComponent();
        }
        private void _RefreshAppointmentData()
        {
            dgvManageAppointement.DataSource = Appointment.All();
        }
        private void frmManageAppointment_Load(object sender, EventArgs e)
        {
            _RefreshAppointmentData();
        }
    }
}
