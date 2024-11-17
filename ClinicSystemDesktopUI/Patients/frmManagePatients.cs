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

        private void tcmUpdate_Click(object sender, EventArgs e)
        {
            int patientId = Convert.ToInt32(dgvManagePatients.CurrentRow.Cells[0].Value);
            _frmMainMenu.OpenChildFormAsync(new frmAddUpdatePatient(patientId));
        }

        private void tcmDelete_Click(object sender, EventArgs e)
        {
            int patientId = Convert.ToInt32(dgvManagePatients.CurrentRow.Cells[0].Value);

            if (MessageBox.Show("Are you sure delete this patient?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (Patient.Delete(patientId))
                {
                    MessageBox.Show("Delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Delete Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            _RefreshPatientsData();
        }
    }
}
