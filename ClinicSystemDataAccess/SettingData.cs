using System.Configuration;

namespace ClinicSystemDataAccess
{
    public static class SettingData
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        // public static string ConnectionString = "Server =.; Database=LibrarySystemDB; User Id=sa; Password=123456sa;";

    }
}
