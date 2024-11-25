using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicSystemDataAccess
{
    public static class PrescriptionData
    {
        public static int Add(string dosage, string frequency, DateTime startDate, DateTime endTime, string specialInstructions, string medicationName, int medicalRecordId)
        {
            int newPrescriptionsId = -1;
            string query = @"insert into Prescriptions (MedicationName,medicalRecordId,Dosage,StartDate,EndDate,Frequency,SpecialInstructions)values
                                                (@medicationName,@medicalRecordId,@dosage,@startDate,@endTime,@frequency,@specialInstructions)
                          SELECT SCOPE_IDENTITY();";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@medicationName", medicationName);
                    command.Parameters.AddWithValue("@medicalRecordId", medicalRecordId);
                    command.Parameters.AddWithValue("@dosage", dosage);
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endTime", endTime);
                    command.Parameters.AddWithValue("@frequency", frequency);
                    command.Parameters.AddWithValue("@specialInstructions", specialInstructions);
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            newPrescriptionsId = insertedID;
                        }
                    }
                    catch (Exception ex) { }
                }
            }
            return newPrescriptionsId;
        }
        public static bool Update(int id, string dosage, string frequency, DateTime startDate, DateTime endDate, string specialInstructions, string medicationName, int medicalRecordId)
        {
            int rowsAffected = 0;
            string query = @"update Prescriptions set
               dosage=@dosage,frequency=@frequency,startDate=@startDate,endDate=@endDate,
               specialInstructions=@specialInstructions,medicationName=@medicationName,medicalRecordId=@medicalRecordId
                                   where Id=@id";

            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@dosage", dosage);
                    command.Parameters.AddWithValue("@frequency", frequency);
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);
                    command.Parameters.AddWithValue("@specialInstructions", specialInstructions);
                    command.Parameters.AddWithValue("@medicationName", medicationName);
                    command.Parameters.AddWithValue("@medicalRecordId", medicalRecordId);

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
            return GenericData.Delete("delete Prescriptions where Id =@id", "@id", id);
        }
        static public bool Exist(int id)
        {
            return GenericData.Exist("select Found=1 from Prescriptions where Id =@id", "@id", id);
        }
        static public DataTable All()
        {
            return GenericData.All("select * from Prescriptions");
        }
        static public bool GetPrescription(int id, ref string dosage, ref string frequency, ref DateTime startDate, ref DateTime endTime, ref string specialInstructions, ref string medicationName, ref int medicalRecordId)
        {
            bool isFound = false;
            string query = @"select * from Prescriptions where Id=@id";
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
                            dosage = (string)reader["Dosage"];
                            frequency = (string)reader["Frequency"];
                            startDate = (DateTime)reader["StartDate"];
                            endTime = (DateTime)reader["EndDate"];
                            specialInstructions = (string)reader["SpecialInstructions"];
                            medicationName = (string)reader["MedicationName"];
                            medicalRecordId = (int)reader["medicalRecordId"];
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
