using ClinicSystemDataAccess;
using System.Data;

namespace ClinicSystemBusiness
{
    public class Employee
    {
        private enum Mode { Add, Update };
        private Mode _Mode;
        public int Id { get; set; }
        public int Salary { get; set; }
        public int PersonId { get; set; }//Fk
        public int CareerId { get; set; }//FK
        public Person Person { get; private set; }//composite
        public Career Career { get; set; }//composite
        public Employee()
        {
            Person Person = new Person();
            Career Career = new Career();
            this.Id = -1;
            this.Salary = 0;
            this.PersonId = -1;
            this.CareerId = -1;
            _Mode = Mode.Add;
        }
        private Employee(int id, int salary, int careerId, int personId)
        {
            Person = Person.Find(personId);
            Career = Career.Find(careerId);
            this.Id = id;
            this.Salary = salary;
            this.PersonId = personId;
            this.CareerId = careerId;
            _Mode = Mode.Update;
        }
        private bool _Add()
        {
            this.Id = EmployeeData.Add(this.Salary, this.CareerId, this.PersonId);
            return (Id != -1);
        }
        private bool _Update()
        {

            return EmployeeData.Update(this.Id, this.Salary, this.CareerId, this.PersonId);
        }
        private bool _ReadyEmployee()
        {
            if (!PersonData.Exist(this.PersonId) || !CareerData.Exist(this.CareerId) || this.Salary <= 0)
            {
                return false;
            }
            return true;
        }
        public bool Save()
        {
            if (!_ReadyEmployee())
            { return false; }
            switch (_Mode)
            {
                case Mode.Add:
                    return _Add();
                case Mode.Update:
                    return _Update();
            }
            return false;
        }
        public static bool Delete(int employeeId)
        {
            if (!Exist(employeeId))
            {
                return false;
            }
            if (Doctor.ExistByEmployeeId(employeeId))
            {
                int doctorId = DoctorData.GetDoctorIdByEmployeeId(employeeId);
                if (!Doctor.Delete(doctorId))
                {
                    return false;
                }
            }
            int PersonId = EmployeeData.GetPersonIdByEmployeeId(employeeId);

            if (!EmployeeData.Delete(employeeId))
            {
                return false;
            }
            else
            {
                return PersonData.Delete(PersonId);
            }
        }
        public static DataTable All()
        {
            return EmployeeData.All();
        }
        public static DataTable ViewSpecificEmployee(int employeeId)
        {
            return EmployeeData.ViewSpecificEmployee(employeeId);
        }
        public static Employee Find(int Id)
        {
            int Salary = 0;
            int CareerId = -1;
            int PersonId = -1;
            if (EmployeeData.GetEmployeeById(Id, ref Salary, ref CareerId, ref PersonId))
            {
                return new Employee(Id, Salary, CareerId, PersonId);
            }
            return null;
        }
        static public bool Exist(int Id)
        {
            return EmployeeData.Exist(Id);
        }

    }
}

