using ClinicSystemDataAccess;
using System.Data;

namespace ClinicSystemBusiness
{
    public class Doctor
    {
        private enum Mode { Add, Update }
        private Mode _mode;
        public int Id { get; set; }
        public int MedicalSpecialtiesId { get; set; }
        public int EmployeeId { get; set; }
        MedicalSpecialties MedicalSpecialties { get; set; }
        Employee Employee { get; set; }

        public Doctor()
        {
            this.Id = -1;
            this.EmployeeId = -1;
            this.MedicalSpecialtiesId = -1;
            this.MedicalSpecialties = new MedicalSpecialties();
            this.Employee = new Employee();
            _mode = Mode.Add;
        }
        private Doctor(int id, int medicalSpecId, int employeeId)
        {
            this.Id = id;
            this.MedicalSpecialtiesId = medicalSpecId;
            this.EmployeeId = employeeId;

            this.MedicalSpecialties = MedicalSpecialties.Find(medicalSpecId);
            this.Employee = Employee.Find(employeeId);
            _mode = Mode.Update;
        }
        private bool _Add()
        {
            this.Id = DoctorData.Add(this.MedicalSpecialtiesId, this.EmployeeId);
            return (this.Id == -1);
        }
        private bool _Update()
        {
            return DoctorData.Update(this.Id, this.MedicalSpecialtiesId, this.EmployeeId);
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
        public static Doctor Find(int id)
        {
            int employeeId = -1;
            int specialtiesId = -1;

            if (DoctorData.GetDoctor(id, ref specialtiesId, ref employeeId))
            {
                return new Doctor(id, specialtiesId, employeeId);
            }
            return null;
        }
        public static DataTable All()
        {
            return DoctorData.All();
        }
        public static bool Exist(int id)
        {
            return DoctorData.Exist(id);
        }
        public static bool Delete(int id)
        {
            if (!Exist(id))
            {
                return false;
            }
            int employeeId = DoctorData.GetEmployeeIdByDoctorId(id);
            if (!DoctorData.Delete(id))
            {
                return false;
            }
            else
            {
                return EmployeeData.Delete(employeeId);
            }
        }
    }
}
