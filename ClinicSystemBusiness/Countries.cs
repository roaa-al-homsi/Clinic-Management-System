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
    }
}
