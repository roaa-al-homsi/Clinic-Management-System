using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicSystemDataAccess
{
    public class AppointmentData
    {
        public static int Add(DateTime date, int patientId, int doctorId, int AppointmentStatusId, int paymentId, int medicalRecordId)
        {
            int newAppointmentId = -1;
            string query = @"insert into Appointments (DateTime,PatientId,DoctorId,AppointmentStatusId,PaymentId,MedicalRecordId)values
                             (@date,@patientId,@doctorId,@AppointmentStatusId,@paymentId,@medicalRecordId)
                          SELECT SCOPE_IDENTITY();";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("date", date);
                    command.Parameters.AddWithValue("patientId", patientId);
                    command.Parameters.AddWithValue("doctorId", doctorId);
                    command.Parameters.AddWithValue("AppointmentStatusId", AppointmentStatusId);
                    command.Parameters.AddWithValue("paymentId", (paymentId == -1) ? 0 : paymentId);
                    command.Parameters.AddWithValue("medicalRecordId", (medicalRecordId == -1) ? 0 : medicalRecordId);
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            newAppointmentId = insertedID;
                        }
                    }
                    catch (Exception ex) { }
                }
            }
            return newAppointmentId;
        }
        public static bool Update(int id, DateTime date, int patientId, int doctorId, int AppointmentStatusId, int paymentId, int medicalRecordId)
        {
            int rowsAffected = 0;
            string query = @"update Appointments set date=@date ,patientId=@patientId ,doctorId=@doctorId,AppointmentStatusId=@AppointmentStatusId
                           ,paymentId=@paymentId,medicalRecordId=@medicalRecordId  where Id=@Id";

            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@patientId", patientId);
                    command.Parameters.AddWithValue("@doctorId", doctorId);
                    command.Parameters.AddWithValue("@AppointmentStatusId", AppointmentStatusId);
                    command.Parameters.AddWithValue("@paymentId", paymentId);
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
            return GenericData.Delete("delete Appointments where Id =@id", "@id", id);
        }
        static public bool Exist(int id)
        {
            return GenericData.Exist("select Found=1 from Appointments where Id =@id", "@id", id);
        }
        static public DataTable All()
        {
            return GenericData.All("select * from View_Appointment_Details");
        }
        static public bool GetAppointment(int id, ref DateTime date, ref int patientId, ref int doctorId, ref int AppointmentStatusId, ref int paymentId, ref int medicalRecordId)
        {
            bool isFound = false;
            string query = @"select * from Appointments where Id=@id";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            isFound = true;
                            patientId = (int)reader["PatientId"];
                            doctorId = (int)reader["DoctorId"];
                            AppointmentStatusId = (int)reader["AppointmentStatusId"];
                            paymentId = (int)reader["PaymentId"];
                            medicalRecordId = (int)reader["MedicalRecordId"];
                            date = (DateTime)reader["DateTime"];
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
