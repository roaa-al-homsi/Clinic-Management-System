using ClinicSystemBusiness;
using System;
using System.Windows.Forms;

namespace ClinicSystem.MedicalRecords
{
    public partial class frmManageMedicalRecord : Form
    {
        public frmManageMedicalRecord()
        {
            InitializeComponent();
        }
        private void _RefreshMedicalData()
        {
            dgvManageMedicalRecords.DataSource = MedicalRecord.All();
        }
        private void frmManageMedicalRecord_Load(object sender, EventArgs e)
        {
            _RefreshMedicalData();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int medicalRecordId = Convert.ToInt32(dgvManageMedicalRecords.CurrentRow.Cells[0].Value);
            frmAddUpdateMedicalRecord frmAddUpdateMedicalRecord = new frmAddUpdateMedicalRecord(medicalRecordId);
            frmAddUpdateMedicalRecord.ShowDialog();
            _RefreshMedicalData();
        }
    }
}
