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
        private DateTime _combinedDateTime;
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
            _appointment = Appointment.Find(_recordId);
            nDoctors.Value = _appointment.DoctorId;
            nPatients.Value = _appointment.PatientId;
            datePicker.Value = _appointment.Date;
            cbStatus.SelectedIndex = cbStatus.FindString(AppointmentStatus.GetNameById(_appointment.AppointmentStatusId));
            labRecordId.Text = _appointment.MedicalRecordId.ToString();
            labPaymentId.Text = _appointment.PaymentId.ToString();

        }
        private void _FillComboAppointmentStatus()
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
                txtSpecialization.Text = MedicalSpecialties.GetNameById(_doctor.MedicalSpecialtiesId);
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
            _FillComboAppointmentStatus();
            cbStatus.SelectedIndex = 0;
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
            DateTime selectedDate = datePicker.Value.Date;
            DateTime selectedTime = timePicker.Value;
            _combinedDateTime = selectedDate.Add(selectedTime.TimeOfDay);
            _appointment.Date = _combinedDateTime;
            _appointment.DoctorId = Convert.ToInt16(labDoctorId.Text);
            _appointment.PatientId = Convert.ToInt16(labPatientId.Text);
            _appointment.MedicalRecordId = string.IsNullOrWhiteSpace(labRecordId.Text) ? -1 : int.TryParse(labRecordId.Text, out int parsedValue) ? parsedValue : -1;
            _appointment.PaymentId = string.IsNullOrWhiteSpace(labPaymentId.Text) ? -1 : int.TryParse(labPaymentId.Text, out int terminalValue) ? terminalValue : -1;
            _appointment.AppointmentStatusId = AppointmentStatus.GetIdByName(cbStatus.Text);
        }
        private bool _AvailableAppointment()
        {

            if (cbStatus.SelectedItem.ToString() == "Pending")
            {
                return Appointment.AvailableAppointment(_appointment.DoctorId, _combinedDateTime);
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _FillAppointment();
            if (!_AvailableAppointment())
            {
                MessageBox.Show("Failed , There is an appointment with this doctor at the same time so you can choose another time. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.SelectedItem.ToString() == "Completed")
            {
                btnSelectMedicalRecord.Enabled = true;
            }

        }
    }
}
