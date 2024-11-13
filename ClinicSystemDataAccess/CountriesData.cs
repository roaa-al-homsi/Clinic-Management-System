using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicSystemDataAccess
{
    static public class CountriesData
    {
        public static DataTable All()
        {
            return GenericData.All("select Name from Countries");
        }
        public static int GetIdByName(string name)
        {
            int countryId = -1;
            string query = @"select Id from Countries where Name = @name;
                          SELECT SCOPE_IDENTITY();";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            countryId = insertedID;
                        }
                    }
                    catch (Exception ex) { }
                }
            }
            return countryId;
        }
        public static string GetNameByID(int id)
        {
            string nameCountry = string.Empty;
            string query = @"select Name from Countries where Id = @id;
                          SELECT SCOPE_IDENTITY();";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            nameCountry = result.ToString();
                        }
                    }
                    catch (Exception ex) { }
                }
            }
            return nameCountry;
        }
    }
}
