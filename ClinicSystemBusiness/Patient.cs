using ClinicSystemDataAccess;
using System.Data;

namespace ClinicSystemBusiness
{
    public class Patient
    {
        private enum Mode { Add, Update }
        private Mode _mode;
        public int Id { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }

        public Patient()
        {
            Person = new Person();
            this.Id = -1;
            this.PersonId = -1;
            _mode = Mode.Add;
        }
        private Patient(int id, int personId)
        {
            Person = Person.Find(personId);
            Id = id;
            PersonId = personId;
            _mode = Mode.Update;
        }
        private bool _Add()
        {
            this.Id = PatientData.Add(this.PersonId);
            return (this.Id == -1);
        }
        private bool _Update()
        {
            return PatientData.Update(this.Id, this.PersonId);
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
        public static Patient Find(int id)
        {
            int personId = -1;
            if (PatientData.GetPatient(id, ref personId))
            {
                return new Patient(id, personId);
            }
            return null;
        }
        public static DataTable All()
        {
            return PatientData.All();
        }
        public static bool Exist(int id)
        {
            return PatientData.Exist(id);
        }
        public static bool Delete(int id)
        {
            if (!Exist(id))
            {
                return false;
            }
            int personId = PatientData.GetPersonIdByPatientId(id);
            if (!PersonData.Delete(personId))
            {
                return false;
            }
            else
            {
                return PatientData.Delete(id);
            }
        }


    }
}
