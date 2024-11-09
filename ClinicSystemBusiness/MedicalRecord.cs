using ClinicSystemDataAccess;
using System.Data;

namespace ClinicSystemBusiness
{
    public class MedicalRecord
    {
        private enum Mode { Add, Update }
        private Mode _mode;
        public int Id { get; set; }
        public string VisitDescription { get; set; }
        public string Diagnosis { get; set; }
        public string AdditionalNotes { get; set; }

        public MedicalRecord()
        {
            this.Id = -1;
            this.VisitDescription = string.Empty;
            this.Diagnosis = string.Empty;
            this.AdditionalNotes = string.Empty;
            _mode = Mode.Add;
        }
        private MedicalRecord(int id, string visitDescription, string diagnosis, string additionalNotes)
        {
            this.Id = id;
            this.VisitDescription = visitDescription;
            this.Diagnosis = diagnosis;
            this.AdditionalNotes = additionalNotes;
            _mode = Mode.Update;
        }
        private bool _Add()
        {
            this.Id = MedicalRecordData.Add(this.VisitDescription, this.Diagnosis, this.AdditionalNotes);
            return (this.Id == -1);
        }
        private bool _Update()
        {
            return MedicalRecordData.Update(this.Id, this.VisitDescription, this.Diagnosis, this.AdditionalNotes);
        }
        public bool Save()
        {
            switch (_mode)
            {
                case Mode.Add: return _Add();
                case Mode.Update: return _Update();
            }
            return false;
        }
        public static MedicalRecord Find(int id)
        {
            string visitDescription = string.Empty;
            string diagnosis = string.Empty;
            string additionalNotes = string.Empty;
            if (MedicalRecordData.GetMedicalRecord(id, ref visitDescription, ref diagnosis, ref additionalNotes))
            {
                return new MedicalRecord(id, visitDescription, diagnosis, additionalNotes);
            }
            return null;
        }
        public static DataTable All()
        {
            return MedicalRecordData.All();
        }
        public static bool Exist(int id)
        {
            return MedicalRecordData.Exist(id);
        }
        public static bool Delete(int id)
        {
            if (!Exist(id))
            {
                return false;
            }
            else
            {
                return MedicalRecordData.Delete(id);
            }
        }
    }
}
