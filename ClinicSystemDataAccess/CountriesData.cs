using System.Data;

namespace ClinicSystemDataAccess
{
    static public class CountriesData
    {
        public static DataTable All()
        {
            return GenericData.All("select Name from Countries");
        }
    }
}
