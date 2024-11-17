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

        private void tsUpdate_Click(object sender, EventArgs e)
        {
            int doctorId = Convert.ToInt32(dgvManageDoctors.CurrentRow.Cells[0].Value);
            _frmMainMenuScreen.OpenChildFormAsync(new frmAddUpdateDoctor(doctorId));
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            int doctorId = Convert.ToInt32(dgvManageDoctors.CurrentRow.Cells[0].Value);

            if (MessageBox.Show("Are you sure delete this doctor?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (Doctor.Delete(doctorId))
                {
                    MessageBox.Show("Delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Delete Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            _RefreshDoctorsData();
        }
    }
}
}
