using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicSystemDataAccess
{
    public static class DoctorData
    {
        public static int Add(int SpecializationId, int employeeId)
        {
            int newDoctorsId = -1;
            string query = @"insert into Doctors (SpecializationId,employeeId)values(@SpecializationId,@employeeId)
                          SELECT SCOPE_IDENTITY();";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SpecializationId", SpecializationId);
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            newDoctorsId = insertedID;
                        }
                    }
                    catch (Exception ex) { }
                }
            }
            return newDoctorsId;
        }
        public static bool Update(int id, int SpecializationId, int employeeId)
        {
            int rowsAffected = 0;
            string query = @"update Doctors set SpecializationId=@SpecializationId,employeeId=@employeeId where Id=@id";

            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    command.Parameters.AddWithValue("@SpecializationId", SpecializationId);
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
            return GenericData.Delete("delete Doctors where Id =@id", "@id", id);
        }
        static public bool Exist(int id)
        {
            return GenericData.Exist("select Found=1 from Doctors where id =@id", "@id", id);
        }
        static public DataTable All()
        {
            return GenericData.All("select * from Doctors");
        }
        static public bool GetDoctor(int id, ref int SpecializationId, ref int employeeId)
        {
            bool isFound = false;
            string query = @"select * from Doctors";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            isFound = true;
                            SpecializationId = (int)reader["SpecializationId"];
                            employeeId = (int)reader["EmployeeId"];
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
        static public int GetEmployeeIdByDoctorId(int doctorId)
        {
            int employeeId = 0;
            string query = @"select EmployeeId from Doctors where Id =@doctorId";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DoctorId", doctorId);
                    try
                    {
                        connection.Open();
                        object Result = command.ExecuteScalar();
                        if (Result != null && int.TryParse(Result.ToString(), out int insertedId))
                        {
                            employeeId = insertedId;
                        }
                    }
                    catch { Exception exception; }
                }
            }
            return employeeId;
        }
    }
}
