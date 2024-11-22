using ClinicSystemBusiness;
using System;
using System.Windows.Forms;

namespace ClinicSystem.Prescriptions
{
    public partial class frmAddUpdatePrescriptions : Form
    {
        private enum Mode { Add, Update }
        private Mode _mode;
        private Prescription _prescription;
        private int _prescriptionId;

        public frmAddUpdatePrescriptions(int prescriptionId)
        {
            InitializeComponent();
            _prescriptionId = prescriptionId;
            _mode = _prescriptionId == -1 ? Mode.Add : Mode.Update;
        }
        private void _LoadPrescriptionData()
        {
            if (_mode == Mode.Add)
            {
                _prescription = new Prescription();
                this.Text = "Add Prescription";
                return;
            }
            this.Text = "Update Prescription";
            _prescription = Prescription.Find(_prescriptionId);
            txtDosage.Text = _prescription.Dosage;
            txtFrequency.Text = _prescription.Frequency;
            txtInstructions.Text = _prescription.SpecialInstructions;
            pickerEndDate.Value = _prescription.EndDate;
            pickerStartDate.Value = _prescription.StartDate;
            labMedicalRecordId.Text = _prescription.MedicalRecordId.ToString();
            labPrescriptionId.Text = _prescription.Id.ToString();
        }
        private void _FillPrescription()
        {
            _prescription.Frequency = txtFrequency.Text;
            _prescription.SpecialInstructions = txtInstructions.Text;
            _prescription.Dosage = txtDosage.Text;
            _prescription.EndDate = pickerEndDate.Value;
            _prescription.StartDate = pickerStartDate.Value;
            _prescription.MedicalRecordId = int.Parse(labMedicalRecordId.Text);
            _prescription.MedicationName = labMedicalRecordId.Text;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _FillPrescription();
            if (_prescription.Save())
            {
                labPrescriptionId.Text = _prescription.Id.ToString();
                MessageBox.Show("Data Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmAddUpdatePrescriptions_Load(object sender, EventArgs e)
        {
            _LoadPrescriptionData();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


