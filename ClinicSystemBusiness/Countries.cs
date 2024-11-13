using ClinicSystemDataAccess;
using System.Data;

namespace ClinicSystemBusiness
{
    public class Countries
    {
        public static DataTable All()
        {
            return CountriesData.All();
        }
        public static int GetIdByName(string name)
        {
            return CountriesData.GetIdByName(name);
        }
        public static string GetNameByID(int id)
        {
            return CountriesData.GetNameByID(id);
        }
    }

}
