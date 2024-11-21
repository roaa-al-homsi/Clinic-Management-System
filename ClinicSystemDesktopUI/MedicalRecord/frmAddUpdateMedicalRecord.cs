using ClinicSystemBusiness;
using System;
using System.Windows.Forms;

namespace ClinicSystem
{
    public partial class frmAddUpdateMedicalRecord : Form
    {
        //Declare a delegate 
        public delegate void DataBackEventHandle(object sender, int PersonId);
        public event DataBackEventHandle DataBack;
        private enum Mode { Add, Update }
        private Mode _mode;
        private int _recordId;

        private MedicalRecord _medicalRecord;
        public frmAddUpdateMedicalRecord(int recordId)
        {
            InitializeComponent();
            _recordId = recordId;
            _mode = _recordId == -1 ? Mode.Add : Mode.Update;
        }
        private void _LoadMedicalRecordData()
        {
            if (_mode == Mode.Add)
            {
                _medicalRecord = new MedicalRecord();

                this.Text = "Add MedicalRecord";
                return;
            }
            this.Text = "Update MedicalRecord";
            _medicalRecord = MedicalRecord.Find(_recordId);
            txtDescription.Text = _medicalRecord.VisitDescription;
            txtNotes.Text = _medicalRecord.AdditionalNotes;
            labRecordId.Text = _medicalRecord.Id.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _medicalRecord.VisitDescription = txtDescription.Text;
            _medicalRecord.Diagnosis = txtDescription.Text;
            _medicalRecord.AdditionalNotes = txtNotes.Text;
            if (_medicalRecord.Save())
            {
                labRecordId.Text = _medicalRecord.Id.ToString();
                MessageBox.Show("Data Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataBack?.Invoke(this, _medicalRecord.Id);
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmAddUpdateMedicalRecord_Load(object sender, EventArgs e)
        {
            _LoadMedicalRecordData();
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            _medicalRecord.VisitDescription = txtDescription.Text;
            _medicalRecord.Diagnosis = txtDiagnosis.Text;
            _medicalRecord.AdditionalNotes = txtNotes.Text;
            if (_medicalRecord.Save())
            {
                labRecordId.Text = _medicalRecord.Id.ToString();
                MessageBox.Show("Data Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataBack?.Invoke(this, _medicalRecord.Id);
        }
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}





