using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicSystemDataAccess
{
    public static class MedicalRecordData
    {
        public static int Add(string visitDescription, string diagnosis, string additionalNotes)
        {
            int newMedicalRecordsId = -1;
            string query = @"insert into MedicalRecords (VisitDescription,Diagnosis,AdditionalNotes)values(@visitDescription,@diagnosis,@additionalNotes)
                          SELECT SCOPE_IDENTITY();";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@visitDescription", visitDescription);
                    command.Parameters.AddWithValue("@diagnosis", diagnosis);
                    command.Parameters.AddWithValue("@additionalNotes", additionalNotes);
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            newMedicalRecordsId = insertedID;
                        }
                    }
                    catch (Exception ex) { }
                }
            }
            return newMedicalRecordsId;
        }
        public static bool Update(int id, string visitDescription, string diagnosis, string additionalNotes)
        {
            int rowsAffected = 0;
            string query = @"update MedicalRecords set VisitDescription=@visitDescription,Diagnosis=@diagnosis,@additionalNotes=@additionalNotes where Id=@id";

            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@visitDescription", visitDescription);
                    command.Parameters.AddWithValue("@diagnosis", diagnosis);
                    command.Parameters.AddWithValue("@AdditionalNotes", additionalNotes);
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
            return GenericData.Delete("delete MedicalRecords where Id =@id", "@id", id);
        }
        static public bool Exist(int id)
        {
            return GenericData.Exist("select Found=1 from MedicalRecords where Id =@id", "@id", id);
        }
        static public DataTable All()
        {
            return GenericData.All("select * from MedicalRecords");
        }
        static public bool GetMedicalRecord(int id, ref string visitDescription, ref string diagnosis, ref string additionalNotes)
        {
            bool isFound = false;
            string query = @"select * from MedicalRecords where Id=@id";
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
                            visitDescription = (string)reader["VisitDescription"];
                            diagnosis = (string)reader["Diagnosis"];
                            additionalNotes = (reader["AdditionalNotes"] == System.DBNull.Value) ? string.Empty : (string)reader["AdditionalNotes"];
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
