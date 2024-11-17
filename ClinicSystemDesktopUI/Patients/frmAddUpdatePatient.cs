using ClinicSystem.Persons;
using ClinicSystemBusiness;
using System;
using System.Windows.Forms;

namespace ClinicSystem.Patients
{
    public partial class frmAddUpdatePatient : Form
    {
        private enum Mode { Add, Update }
        private Mode _mode;
        private int _patientId;
        private Patient _patient;
        public frmAddUpdatePatient(int patientId)
        {
            InitializeComponent();
            _patientId = patientId;
            _mode = patientId == -1 ? Mode.Add : Mode.Update;
        }

        private void _LoadPatientData()
        {
            if (_mode == Mode.Add)
            {
                _patient = new Patient();
                this.Tag = "Add Patient";
                return;
            }
            _patient = Patient.Find(_patientId);
            this.Tag = "Update Patient";
            labPatientId.Text = _patient.Id.ToString();
            labPersonId.Text = _patient.PersonId.ToString();
        }
        private void btnSelectPerson_Click_1(object sender, EventArgs e)
        {
            frmAddUpdatePersons addUpdatePersons = new frmAddUpdatePersons(_patient.PersonId);
            addUpdatePersons.DataBack += DataBackPerson;
            addUpdatePersons.ShowDialog();
        }
        private void DataBackPerson(object sender, int personId)
        {
            Person person = Person.Find(personId);
            if (person != null)
            {
                uc_personInfo1.ViewDataPerson(person);
                labPersonId.Text = personId.ToString();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmAddUpdatePatient_Load(object sender, EventArgs e)
        {
            _LoadPatientData();
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            _patient.PersonId = int.Parse(labPersonId.Text);
            if (_patient.Save())
            {
                labPatientId.Text = _patient.Id.ToString();
                MessageBox.Show("Data Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
