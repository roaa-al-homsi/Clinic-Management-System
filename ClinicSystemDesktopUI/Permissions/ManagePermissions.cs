using ClinicSystem.Login;

namespace ClinicSystem.Permissions
{
    public class ManagePermissions
    {
        public enum enMainMenuPermission { All = -1, Doctors = 1, Patients = 2, Appointments = 4, Payments = 8, Employees = 16, Users = 32 };
        public static bool CheckAccessPermission(enMainMenuPermission menuPermission)
        {
            if (frmMainLogin.CurrentUser.Permission == -1)
            {
                return true;
            }
            return (((int)menuPermission & frmMainLogin.CurrentUser.Permission) == (int)menuPermission);
        }
        public static bool CheckAccessPermission(int Permission_User, enMainMenuPermission menuPermission)
        {
            if (frmMainLogin.CurrentUser.Permission == -1)
            {
                return true;
            }
            return (((int)menuPermission & Permission_User) == (int)menuPermission);
        }
    }
}
