using ClinicSystemBusiness;
using System;
using System.Windows.Forms;

namespace ClinicSystem.Prescriptions
{
    public partial class frmManagePrescriptions : Form
    {
        public frmManagePrescriptions()
        {
            InitializeComponent();
        }
        private void _RefreshPrescriptionsData()
        {
            dgvManagePrescriptions.DataSource = Prescription.All();
        }
        private void frmManagePrescriptions_Load(object sender, EventArgs e)
        {
            _RefreshPrescriptionsData();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int prescriptionId = Convert.ToInt32(dgvManagePrescriptions.CurrentRow.Cells[0].Value);
            int medicalRecordId = Convert.ToInt32(dgvManagePrescriptions.CurrentRow.Cells[7].Value);
            frmAddUpdatePrescriptions frmAddUpdate = new frmAddUpdatePrescriptions(prescriptionId, medicalRecordId);
            frmAddUpdate.ShowDialog();
            _RefreshPrescriptionsData();
        }
    }
}
