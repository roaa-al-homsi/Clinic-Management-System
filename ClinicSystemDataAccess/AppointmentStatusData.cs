using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicSystemDataAccess
{
    public static class AppointmentStatusData
    {
        public static int Add(string name)
        {
            int newId = -1;
            string query = @"insert into AppointmentStatus (Name)values(@Name)
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
            string query = @"update AppointmentStatus set Name=@name where Id=@Id";

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
            return GenericData.Delete("delete AppointmentStatus where Id =@id", "@id", id);
        }
        static public bool Exist(int id)
        {
            return GenericData.Exist("select Found=1 from AppointmentStatus where Id =@id", "@id", id);
        }
        static public DataTable All()
        {
            return GenericData.All("select * from AppointmentStatus");
        }
        static public bool GetAppointmentStatus(int id, ref string name)
        {
            bool isFound = false;
            string query = @"select * from AppointmentStatus";
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
        static public string GetNameById(int id)
        {
            string name = string.Empty;
            string query = @"select Name from AppointmentStatus where Id = @id;
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
                            name = result.ToString();
                        }
                    }
                    catch (Exception ex) { }
                }
            }
            return name;
        }
        static public int GetIdByName(string name)
        {
            int id = -1;
            string query = @"select Id from AppointmentStatus where Name = @name;
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
                            id = insertedID;
                        }
                    }
                    catch (Exception ex) { }
                }
            }
            return id;
        }
    }
}
