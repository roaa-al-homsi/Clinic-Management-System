using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicSystemDataAccess
{
    public static class CareerData
    {
        public static int Add(string name)
        {
            int newCareerId = -1;
            string query = @"insert into CareerSpecializations (Name)values(@Name)
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
                            newCareerId = insertedID;
                        }
                    }
                    catch (Exception ex) { }

                }
            }
            return newCareerId;
        }
        public static bool Update(int id, string name)
        {
            int rowsAffected = 0;
            string query = @"update CareerSpecializations set Name=@name where Id=@Id";

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
            return GenericData.Delete("delete CareerSpecializations where Id =@id", "@id", id);
        }
        static public bool Exist(int id)
        {
            return GenericData.Exist("select Found=1 from CareerSpecializations where id =@id", "@id", id);
        }
        static public DataTable All()
        {
            return GenericData.All("select * from CareerSpecializations");
        }
        static public bool GetCareer(int id, ref string name)
        {
            bool isFound = false;
            string query = @"select * from CareerSpecializations";
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
        static public int GetCareerIdByName(string name)
        {
            int CareerId = -1;
            string query = @"select Id from CareerSpecializations where Name = @name;
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
                            CareerId = insertedID;
                        }
                    }
                    catch (Exception ex) { }
                }
            }
            return CareerId;
        }
        static public string GetNameById(int id)
        {
            string name = string.Empty;
            string query = @"select Name from CareerSpecializations where Id = @id;
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
    }
}

