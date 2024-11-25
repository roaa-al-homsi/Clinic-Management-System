using ClinicSystemDataAccess;
using System;
using System.Data;

namespace ClinicSystemBusiness
{
    public class Appointment
    {
        private enum Mode { Add, Update }
        private Mode _mode;

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public int AppointmentStatusId { get; set; }
        public int PaymentId { get; set; }
        public int MedicalRecordId { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public AppointmentStatus AppointmentStatus { get; set; }
        public Payment Payment { get; set; }
        public MedicalRecord MedicalRecord { get; set; }
        public Appointment()
        {
            this.Date = DateTime.MinValue;
            this.PatientId = -1;
            this.DoctorId = -1;
            this.AppointmentStatusId = -1;
            this.PaymentId = -1;
            this.MedicalRecordId = -1;
            this.Id = -1;
            Patient = new Patient();
            Doctor = new Doctor();
            AppointmentStatus = new AppointmentStatus();
            MedicalRecord = new MedicalRecord();
            Payment = new Payment();

            _mode = Mode.Add;
        }
        private Appointment(int id, DateTime date, int patientId, int doctorId, int appointmentStatusId, int paymentId, int medicalRecordId)
        {
            this.Date = date;
            this.PatientId = patientId;
            this.DoctorId = doctorId;
            this.AppointmentStatusId = appointmentStatusId;
            this.PaymentId = paymentId;
            this.MedicalRecordId = medicalRecordId;
            this.Id = id;
            this.Patient = Patient.Find(patientId);
            this.Doctor = Doctor.Find(doctorId);
            this.AppointmentStatus = AppointmentStatus.Find(appointmentStatusId);
            this.MedicalRecord = MedicalRecord.Find(medicalRecordId);
            this.Payment = Payment.Find(paymentId);

            _mode = Mode.Update;
        }

        private bool _Add()
        {
            this.Id = AppointmentData.Add(this.Date, this.PatientId, this.DoctorId, this.AppointmentStatusId, this.PaymentId, this.MedicalRecordId);
            return (this.Id != -1);
        }
        private bool _Update()
        {
            return AppointmentData.Update(this.Id, this.Date, this.PatientId, this.DoctorId, this.AppointmentStatusId, this.PaymentId, this.MedicalRecordId);
        }
        private bool _ReadyAppointment()
        {
            if ((!Exist(this.Id) && _mode == Mode.Update)
                || !Patient.Exist(this.PatientId)
                || !Doctor.Exist(this.DoctorId)
                || !AppointmentStatus.Exist(this.AppointmentStatusId))

            {
                return false;
            }
            return true;
        }
        public bool Save()
        {
            if (!_ReadyAppointment())
            {
                return false;
            }
            switch (_mode)
            {
                case Mode.Add: return _Add();
                case Mode.Update: return _Update();
            }
            return false;
        }
        public static Appointment Find(int id)
        {
            DateTime date = DateTime.MinValue;
            int patientId = -1;
            int doctorId = -1;
            int appointmentStatusId = -1;
            int paymentId = -1;
            int medicalRecordId = -1;
            if (AppointmentData.GetAppointment(id, ref date, ref patientId, ref doctorId, ref appointmentStatusId, ref paymentId, ref medicalRecordId))
            {
                return new Appointment(id, date, patientId, doctorId, appointmentStatusId, paymentId, medicalRecordId);
            }
            return null;
        }
        public static DataTable All()
        {
            return AppointmentData.All();
        }
        public static bool Exist(int id)
        {
            return AppointmentData.Exist(id);
        }
        public static bool Delete(int id)
        {
            if (!Exist(id))
            {
                return false;
            }
            return AppointmentData.Delete(id);
        }
        public static bool AvailableAppointment(int doctorId, DateTime dateTime)
        {
            return AppointmentData.AvailableAppointment(doctorId, dateTime);
        }
    }
}
