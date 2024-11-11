using ClinicSystemDataAccess;
using System.Data;

namespace ClinicSystemBusiness
{
    public class User
    {
        private enum ModeUser { Add, Update };
        private ModeUser _Mode;
        public Person Person { get; private set; }//composition
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Permission { get; set; }

        public User()
        {
            Person Person = new Person();
            this.Id = -1;
            this.PersonId = -1;
            this.UserName = string.Empty;
            this.Password = string.Empty;
            this.Permission = 0;
            _Mode = ModeUser.Add;
        }
        private User(int Id, int PersonId, string UerName, string Password, int Permission)
        {
            Person = Person.Find(PersonId);
            this.Id = Id;
            this.PersonId = PersonId;
            this.UserName = UerName;
            this.Password = Password;
            this.Permission = Permission;
            _Mode = ModeUser.Update;
        }

        private bool _Add()
        {
            //validation
            this.Id = UserData.Add(this.UserName, this.Password, this.Permission, this.PersonId);
            return (Id != -1);
        }
        private bool _Update()
        {
            //validation
            return UserData.Update(this.Id, this.UserName, this.Password, this.Permission, this.PersonId);
        }
        private bool _ReadyUser()
        {
            if (!ExistByUserName(this.UserName) && _Mode == ModeUser.Update)
            {
                return false;
            }
            if (!PersonData.Exist(this.PersonId) || string.IsNullOrWhiteSpace(this.Password) || this.Permission == 0)
            {
                return false;
            }
            return true;
        }
        public bool Save()
        {
            if (!_ReadyUser())
            {
                return false;
            }
            switch (_Mode)
            {
                case ModeUser.Add:
                    return _Add();
                case ModeUser.Update:
                    return _Update();
            }
            return false;
        }
        public static bool Delete(int Id)
        {
            return UserData.Delete(Id);
        }
        public static DataTable All()
        {
            return UserData.All();
        }
        public static User Find(string UserName)
        {
            int Id = -1;
            int PersonId = -1;
            string Password = string.Empty;
            int Permission = 0;

            if (UserData.GetUserByUserName(ref PersonId, ref Id, UserName, ref Password, ref Permission))
            {
                return new User(Id, PersonId, UserName, Password, Permission);
            }
            return null;
        }
        public static User FindById(int UserId)
        {
            string UserName = string.Empty;
            int PersonId = -1;
            string Password = string.Empty;
            int Permission = 0;

            if (UserData.GetUserById(ref PersonId, UserId, ref UserName, ref Password, ref Permission))
            {
                return new User(UserId, PersonId, UserName, Password, Permission);
            }
            return null;
        }
        static public User FindByUserNameAndPassword(string UserName, string Password)
        {
            int Id = -1;
            int PersonId = -1;
            int Permission = 0;
            if (UserData.GetUserByUsernameAndPassword(ref PersonId, ref Id, UserName, Password, ref Permission))
            {
                return new User(Id, PersonId, UserName, Password, Permission);
            }
            return null;
        }
        public static bool Exist(int Id)
        {
            return UserData.Exist(Id);
        }
        public static bool ExistByUserName(string UserName)
        {
            return UserData.ExistByUserName(UserName);
        }

    }
}
