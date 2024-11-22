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
            _frmMainMenuScreen.OpenChildFormAsync(new frmAddUpdateAppointment(-1));
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int appointmentId = Convert.ToInt16(dgvManageAppointement.CurrentRow.Cells[0].Value);
            _frmMainMenuScreen.OpenChildFormAsync(new frmAddUpdateAppointment(appointmentId));
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int appointmentId = Convert.ToInt16(dgvManageAppointement.CurrentRow.Cells[0].Value);

            if (MessageBox.Show("Are you sure delete this doctor?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (Appointment.Delete(appointmentId))
                {
                    MessageBox.Show("Delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Delete Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            _RefreshAppointmentData();
        }
    }
}
