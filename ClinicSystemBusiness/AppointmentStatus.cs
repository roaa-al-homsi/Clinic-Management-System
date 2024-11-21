using ClinicSystemDataAccess;
using System.Data;

namespace ClinicSystemBusiness
{
    public class AppointmentStatus
    {
        private enum Mode { Add, Update };
        private Mode _mode;
        public int Id { get; set; }
        public string Name { get; set; }

        public AppointmentStatus()
        {
            this.Id = -1;
            this.Name = string.Empty;
            _mode = Mode.Add;
        }
        public AppointmentStatus(int id, string name)
        {
            Id = id;
            Name = name;
            _mode = Mode.Update;
        }
        private bool _Add()
        {
            this.Id = AppointmentStatusData.Add(this.Name);
            return (this.Id == -1);
        }
        private bool _Update()
        {
            return AppointmentStatusData.Update(this.Id, this.Name);
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
        public static AppointmentStatus Find(int id)
        {
            string name = string.Empty;
            if (AppointmentStatusData.GetAppointmentStatus(id, ref name))
            {
                return new AppointmentStatus(id, name);
            }
            return null;
        }
        public static DataTable All()
        {
            return AppointmentStatusData.All();
        }
        public static bool Exist(int id)
        {
            return AppointmentStatusData.Exist(id);
        }
        public static bool Delete(int id)
        {
            if (!Exist(id))
            {
                return false;
            }
            return AppointmentStatusData.Delete(id);
        }
        public static string GetNameById(int id)
        {
            return AppointmentStatusData.GetNameById(id);
        }
        public static int GetIdByName(string name)
        {
            return AppointmentStatusData.GetIdByName(name);
        }
    }
}
