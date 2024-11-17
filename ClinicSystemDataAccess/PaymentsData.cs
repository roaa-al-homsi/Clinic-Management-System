using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicSystemDataAccess
{
    public static class PaymentsData
    {
        public static int Add(DateTime date, int amount, string additionalNotes, int PaymentMethodsId)
        {
            int newPaymentsId = -1;
            string query = @"insert into Payments (date,amount,AdditionalNotes,PaymentMethodsId)values(@date,@amount,@additionalNotes,@PaymentMethodsId)
                          SELECT SCOPE_IDENTITY();";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@amount", amount);
                    command.Parameters.AddWithValue("@PaymentMethodsId", PaymentMethodsId);
                    command.Parameters.AddWithValue("@additionalNotes", (!string.IsNullOrEmpty(additionalNotes) ? additionalNotes : (object)System.DBNull.Value));
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            newPaymentsId = insertedID;
                        }
                    }
                    catch (Exception ex) { }
                }
            }
            return newPaymentsId;
        }
        public static bool Update(int id, DateTime date, int amount, string additionalNotes, int PaymentMethodsId)
        {
            int rowsAffected = 0;
            string query = @"update Payments set amount=@amount,additionalNotes=@additionalNotes,PaymentMethodsId=@PaymentMethodsId where Id=@id";

            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@amount", amount);
                    command.Parameters.AddWithValue("@PaymentMethodsId", PaymentMethodsId);
                    command.Parameters.AddWithValue("@AdditionalNotes", !string.IsNullOrWhiteSpace(additionalNotes) ? additionalNotes : (object)System.DBNull.Value);
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
            return GenericData.Delete("delete Payments where Id =@id", "@id", id);
        }
        static public bool Exist(int id)
        {
            return GenericData.Exist("select Found=1 from Payments where Id =@id", "@id", id);
        }
        static public DataTable All()
        {
            return GenericData.All("select * from View_Payment_Details");
        }
        static public bool GetPayment(int id, ref DateTime date, ref int amount, ref string additionalNotes, ref int PaymentMethodsId)
        {
            bool isFound = false;
            string query = @"select * from Payments where Id=@id";
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
                            date = (DateTime)reader["Date"];
                            amount = (int)reader["Amount"];
                            PaymentMethodsId = (int)reader["PaymentMethodsId"];
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
