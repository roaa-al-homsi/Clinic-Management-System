using ClinicSystemDataAccess;
using System.Data;

namespace ClinicSystemBusiness
{
    public class Career
    {
        private enum Mode { Add, Update };
        private Mode _mode;
        public int Id { get; set; }
        public string Name { get; set; }

        public Career()
        {
            this.Id = -1;
            this.Name = string.Empty;
            _mode = Mode.Add;
        }
        public Career(int id, string name)
        {
            Id = id;
            Name = name;
            _mode = Mode.Update;
        }
        private bool _Add()
        {
            this.Id = CareerData.Add(this.Name);
            return (this.Id == -1);
        }
        private bool _Update()
        {
            return CareerData.Update(this.Id, this.Name);
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
        public static Career Find(int id)
        {
            string name = string.Empty;
            if (CareerData.GetCareer(id, ref name))
            {
                return new Career(id, name);
            }
            return null;
        }
        public static DataTable All()
        {
            return CareerData.All();
        }
        public static bool Exist(int id)
        {
            return CareerData.Exist(id);
        }
        public static bool Delete(int id)
        {
            if (!Exist(id))
            {
                return false;
            }
            return CareerData.Delete(id);
        }
    }
}

