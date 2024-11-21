using ClinicSystem.Payments;
using ClinicSystemBusiness;
using System;
using System.Data;
using System.Windows.Forms;

namespace ClinicSystem.Appointments
{
    public partial class frmAddUpdateAppointment : Form
    {
        private enum Mode { Add, Update }
        private Mode _mode;
        private Patient _patient;
        private Doctor _doctor;
        private Appointment _appointment;
        private int _recordId;
        public frmAddUpdateAppointment(int recordId)
        {
            InitializeComponent();
            _recordId = recordId;
            _mode = _recordId == -1 ? Mode.Add : Mode.Update;
        }
        private void _LoadMedicalRecordData()
        {
            if (_mode == Mode.Add)
            {
                this.Tag = "Add Appointment";
                _appointment = new Appointment();
                return;
            }
            this.Tag = "Update Appointment";
            btnSelectMedicalRecord.Enabled = false;
            nDoctors.Value = _appointment.DoctorId;
            nPatients.Value = _appointment.PatientId;
            dtDate.Value = _appointment.Date;
            cbStatus.SelectedIndex = cbStatus.FindString(AppointmentStatus.GetNameById(_appointment.AppointmentStatusId));
            labRecordId.Text = _appointment.MedicalRecordId.ToString();
            labPaymentId.Text = _appointment.MedicalRecordId.ToString();

        }
        private void _FillComboPaymentsMethods()
        {
            DataTable dataTable = AppointmentStatus.All();
            foreach (DataRow row in dataTable.Rows)
            {
                cbStatus.Items.Add(row["Name"]);
            }
        }
        private void nDoctors_ValueChanged(object sender, System.EventArgs e)
        {
            int doctorId = Convert.ToInt16(nDoctors.Value);
            _doctor = Doctor.Find(doctorId);
            if (_doctor != null)
            {
                uc_doctor.ViewDataPerson(_doctor.Employee.Person);
                labDoctorId.Text = doctorId.ToString();
            }
        }
        private void nPatients_ValueChanged(object sender, EventArgs e)
        {
            int patientId = Convert.ToInt16(nPatients.Value);
            _patient = Patient.Find(patientId);
            if (_patient != null)
            {
                uc_patient.ViewDataPerson(_patient.Person);
                labPatientId.Text = patientId.ToString();
            }
        }
        private void frmAddUpdateAppointment_Load(object sender, EventArgs e)
        {
            _FillComboPaymentsMethods();
            _LoadMedicalRecordData();
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            frmAddUpdatePayment addUpdatePayment = new frmAddUpdatePayment(-1);
            addUpdatePayment.DataBack += DataBackPayment;
            addUpdatePayment.ShowDialog();
        }
        private void DataBackPayment(object sender, int paymentId)
        {
            labPaymentId.Visible = true;
            labPaymentId.Text = paymentId.ToString();
        }
        private void DataBackMedicalRecord(object sender, int MedicalRecordId)
        {
            labRecordId.Visible = true;
            labRecordId.Text = MedicalRecordId.ToString();
        }
        private void btnSelectMedicalRecord_Click(object sender, EventArgs e)
        {
            frmAddUpdateMedicalRecord frmAddUpdateMedical = new frmAddUpdateMedicalRecord(-1);
            frmAddUpdateMedical.DataBack += DataBackMedicalRecord;
            frmAddUpdateMedical.ShowDialog();
        }
        private void _FillAppointment()
        {
            _appointment.DoctorId = Convert.ToInt16(labDoctorId.Text);
            _appointment.PatientId = Convert.ToInt16(labPatientId.Text);
            _appointment.MedicalRecordId = Convert.ToInt16(labRecordId.Text);
            _appointment.PaymentId = Convert.ToInt16(labPaymentId.Text);
            _appointment.Date = dtDate.Value;
            _appointment.AppointmentStatusId = AppointmentStatus.GetIdByName(cbStatus.Text);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _FillAppointment();
            if (_appointment.Save())
            {
                labPaymentId.Text = _appointment.Id.ToString();
                MessageBox.Show("Data Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
