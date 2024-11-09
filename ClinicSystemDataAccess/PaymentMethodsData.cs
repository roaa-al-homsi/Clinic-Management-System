using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicSystemDataAccess
{
    public static class PaymentMethodsData
    {
        public static int Add(string name)
        {
            int newId = -1;
            string query = @"insert into PaymentMethods (Name)values(@Name)
                          SELECT SCOPE_IDENTITY();";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("name", name);
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            newId = insertedID;
                        }
                    }
                    catch (Exception ex) { }

                }
            }
            return newId;
        }
        public static bool Update(int id, string name)
        {
            int rowsAffected = 0;
            string query = @"update PaymentMethods set Name=@name where Id=@Id";

            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@name", name);
                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();

                    }
                    catch (Exception ex) { }
                }
            }
            return rowsAffected > 0;
        }
        static public bool Delete(int id)
        {
            return GenericData.Delete("delete PaymentMethods where Id =@id", "@id", id);
        }
        static public bool Exist(int id)
        {
            return GenericData.Exist("select Found=1 from PaymentMethods where id =@id", "@id", id);
        }
        static public DataTable All()
        {
            return GenericData.All("select * from PaymentMethods");
        }
        static public bool GetPaymentMethods(int id, ref string name)
        {
            bool isFound = false;
            string query = @"select * from PaymentMethods";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@name", name);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            isFound = true;
                            name = (string)reader["Name"];
                        }
                        else
                        {
                            isFound = false;
                        }
                    }
                    catch (Exception ex) { }
                }
            }
            return isFound;
        }
    }
}
