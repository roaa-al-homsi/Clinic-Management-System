using ClinicSystemDataAccess;
using System.Data;

namespace ClinicSystemBusiness
{
    public class MedicalSpecialties
    {
        private enum Mode { Add, Update };
        private Mode _mode;
        public int Id { get; set; }
        public string Name { get; set; }

        public MedicalSpecialties()
        {
            this.Id = -1;
            this.Name = string.Empty;
            _mode = Mode.Add;
        }
        public MedicalSpecialties(int id, string name)
        {
            Id = id;
            Name = name;
            _mode = Mode.Update;
        }
        private bool _Add()
        {
            this.Id = MedicalSpecialtiesData.Add(this.Name);
            return (this.Id == -1);
        }
        private bool _Update()
        {
            return MedicalSpecialtiesData.Update(this.Id, this.Name);
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
        public static MedicalSpecialties Find(int id)
        {
            string name = string.Empty;
            if (MedicalSpecialtiesData.GetMedicalSpecialties(id, ref name))
            {
                return new MedicalSpecialties(id, name);
            }
            return null;
        }
        public static DataTable All()
        {
            return MedicalSpecialtiesData.All();
        }
        public static bool Exist(int id)
        {
            return MedicalSpecialtiesData.Exist(id);
        }
        public static bool Delete(int id)
        {
            if (!Exist(id))
            {
                return false;
            }
            return MedicalSpecialtiesData.Delete(id);
        }


    }
}
