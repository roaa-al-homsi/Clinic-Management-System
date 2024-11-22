using ClinicSystemDataAccess;
using System;
using System.Data;

namespace ClinicSystemBusiness
{
    public class Prescription
    {
        private enum Mode { Add, Update }
        private Mode _mode;
        public int Id { get; set; }
        public string MedicationName { get; set; }
        public string Dosage { get; set; }
        public string Frequency { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string SpecialInstructions { get; set; }
        public int MedicalRecordId { get; set; }
        public MedicalRecord MedicalRecord { get; private set; }

        public Prescription()
        {
            this.MedicalRecordId = -1;
            this.Id = -1;
            this.Dosage = string.Empty;
            this.Frequency = string.Empty;
            this.StartDate = DateTime.MinValue;
            this.EndDate = DateTime.MinValue;
            this.SpecialInstructions = string.Empty;
            this.MedicationName = string.Empty;
            MedicalRecord = new MedicalRecord();
            _mode = Mode.Add;
        }
        private Prescription(int id, string dosage, string frequency, DateTime startDate, DateTime endTime, string specialInstructions, string medicationName, int medicalRecordId)
        {
            this.Id = id;
            this.Dosage = dosage;
            this.Frequency = frequency;
            this.StartDate = startDate;
            this.EndDate = endTime;
            this.SpecialInstructions = specialInstructions;
            this.MedicationName = medicationName;
            this.MedicalRecordId = medicalRecordId;
            this.MedicalRecord = MedicalRecord.Find(MedicalRecordId);
            _mode = Mode.Update;
        }

        private bool _Add()
        {
            this.Id = PrescriptionData.Add(this.Dosage, this.Frequency, this.StartDate, this.EndDate, this.SpecialInstructions, this.MedicationName, this.MedicalRecordId);
            return (Id != -1);
        }
        private bool _Update()
        {
            return PrescriptionData.Update(this.Id, this.Dosage, this.Frequency, this.StartDate, this.EndDate, this.SpecialInstructions, this.MedicationName, this.MedicalRecordId);
        }
        private bool _ReadyPrescription()
        {
            if ((!Exist(this.Id) && _mode == Mode.Update) ||
               string.IsNullOrWhiteSpace(this.Frequency) ||
               string.IsNullOrWhiteSpace(this.Dosage) ||
               string.IsNullOrWhiteSpace(this.MedicationName) ||
               string.IsNullOrWhiteSpace(this.SpecialInstructions) ||
               this.StartDate == DateTime.MinValue || this.EndDate == DateTime.MinValue ||
                !MedicalRecord.Exist(this.MedicalRecordId))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool Save()
        {
            if (!_ReadyPrescription())
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
        public static bool Delete(int Id)
        {
            return PrescriptionData.Delete(Id);
        }
        public static DataTable All()
        {
            return PrescriptionData.All();
        }
        public static Prescription Find(int id)
        {
            string dosage = string.Empty;
            string frequency = string.Empty;
            DateTime startDate = DateTime.MinValue;
            DateTime endTime = DateTime.MinValue;
            string specialInstructions = string.Empty;
            string medicationName = string.Empty;
            int medicalRecordId = -1;

            if (PrescriptionData.GetPrescription(id, ref dosage, ref frequency, ref startDate, ref endTime, ref specialInstructions, ref medicationName, ref medicalRecordId))
            {
                return new Prescription(id, dosage, frequency, startDate, endTime, specialInstructions, medicationName, medicalRecordId);
            }
            return null;
        }

        public static bool Exist(int Id)
        {
            return PrescriptionData.Exist(Id);
        }

    }
}
