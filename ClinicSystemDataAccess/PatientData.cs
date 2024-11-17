using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicSystemDataAccess
{
    public static class PatientData
    {
        public static int Add(int personId)
        {
            int newPatientsId = -1;
            string query = @"insert into Patients (PersonId)values(@personId)
                          SELECT SCOPE_IDENTITY();";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("personId", personId);
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            newPatientsId = insertedID;
                        }
                    }
                    catch (Exception ex) { }
                }
            }
            return newPatientsId;
        }
        public static bool Update(int id, int personId)
        {
            int rowsAffected = 0;
            string query = @"update Patients set PersonId=@personId where Id=@id";

            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@personId", personId);
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
            return GenericData.Delete("delete Patients where Id =@id", "@id", id);
        }
        static public bool Exist(int id)
        {
            return GenericData.Exist("select Found=1 from Patients where id =@id", "@id", id);
        }
        static public DataTable All()
        {
            return GenericData.All("select * from View_Patient_Details");
        }
        static public bool GetPatient(int id, ref int personId)
        {
            bool isFound = false;
            string query = @"select * from Patients where Id=@id";
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
                            personId = (int)reader["PersonId"];
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
        static public int GetPersonIdByPatientId(int patientId)
        {
            int personID = 0;
            string query = @"select PersonId from Patients where Id =@patientId";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@patientId", patientId);
                    try
                    {
                        connection.Open();
                        object Result = command.ExecuteScalar();
                        if (Result != null && int.TryParse(Result.ToString(), out int insertedId))
                        {
                            personID = insertedId;
                        }
                    }
                    catch { Exception exception; }
                }
            }
            return personID;
        }
    }
}
