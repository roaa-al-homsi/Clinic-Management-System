using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicSystemDataAccess
{
    public class EmployeeData
    {
        static public int Add(int salary, int careerId, int PersonId)
        {
            int NewIdEmployeer = 0;
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"insert into Employees (Salary,careerId,PersonId) values (@salary,@careerId,@PersonId)
                           SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@salary", salary);
            command.Parameters.AddWithValue("@careerId", careerId);
            command.Parameters.AddWithValue("@PersonId", PersonId);
            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int insertedId))
                {
                    NewIdEmployeer = insertedId;
                }
            }
            catch { }
            finally { connection.Close(); }
            return NewIdEmployeer;
        }
        static public bool Update(int Id, int salary, int careerId, int PersonId)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"update Employees Salary=@salary ,careerId=@careerId,PersonId=@PersonId
				   where Id=@Id;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@salary", salary);
            command.Parameters.AddWithValue("@PersonId", PersonId);
            command.Parameters.AddWithValue("@careerId", careerId);
            command.Parameters.AddWithValue("@Id", Id);
            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();
            }
            catch { Exception exception; }
            finally { connection.Close(); }
            return RowAffected > 0;
        }
        static public bool Delete(int Id)
        {
            return GenericData.Delete("Delete Employees where Id=@Id", "@Id", Id);
        }
        static public DataTable All()
        {
            return GenericData.All("select * from View_Employees_Details");
        }
        static public DataTable ViewSpecificEmployee(int EmployeeId)
        {
            return GenericData.ShowDataForSpecificObject("select * from View_Employees_Details where EmployeeId=@EmployeeId", "@EmployeeId", EmployeeId);

        }
        static public bool GetEmployeeById(int Id, ref int salary, ref int careerId, ref int PersonId)
        {
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"select * from Employees where Id =@Id";

            bool IsFound = false;
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", Id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    PersonId = (int)reader["PersonId"];
                    careerId = (int)reader["CareerId"];
                    salary = (int)reader["Salary"];
                }
                else
                {
                    IsFound = false;
                }
                reader.Close();
            }
            catch { Exception exception; }
            finally { connection.Close(); }
            return IsFound;
        }
        static public int GetPersonIdByEmployeeId(int EmployeeId)
        {
            int PersonID = 0;
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"select PersonId from Employees where Id =@EmployeeId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@EmployeeId", EmployeeId);
            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int insertedId))
                {
                    PersonID = insertedId;
                }
            }
            catch { Exception exception; }
            finally { connection.Close(); }
            return PersonID;
        }
        static public bool Exist(int Id)
        {
            return GenericData.Exist("select Found=1 from Employees where Id =@Id", "@Id", Id);
        }
    }
}
