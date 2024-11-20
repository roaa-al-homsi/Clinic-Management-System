using ClinicSystemBusiness;
using System;
using System.Windows.Forms;

namespace ClinicSystem
{
    public partial class frmAddUpdateMedicalRecord : Form
    {
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

            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmAddUpdateMedicalRecord_Load(object sender, EventArgs e)
        {
            _LoadMedicalRecordData();
        }
    }
}
