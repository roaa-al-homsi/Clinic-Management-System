using System;
using System.Data.SqlClient;

namespace ClinicSystemDataAccess
{
    public static class PersonData
    {
        public static int Add(string Name, DateTime BirthDate, string Gender, string Phone, string Email, int CountryId, string Address, string ImagePath)
        {
            int IdNewPerson = 0;

            string query = @"INSERT INTO Persons (Name, BirthDate, Gender, Phone, Email, CountryId, Address, ImagePath)
                     VALUES (@Name, @BirthDate, @Gender, @Phone, @Email, @CountryId, @Address, @ImagePath);
                     SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@BirthDate", BirthDate);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@CountryId", CountryId);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@ImagePath", !string.IsNullOrWhiteSpace(ImagePath) ? ImagePath : (object)DBNull.Value);
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            IdNewPerson = insertedID;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log or handle the exception as needed
                    }
                }
            }

            return IdNewPerson;
        }
        static public bool Delete(int Id)
        {
            return GenericData.Delete("delete Persons where Id =@Id", "@Id", Id);
        }
        public static bool Update(int Id, string Name, DateTime BirthDate, string Gender, string Phone, string Email, int CountryId, string Address, string ImagePath)
        {
            int RowsAffected = 0;

            string query = @"UPDATE Persons 
                     SET Name=@Name, BirthDate=@BirthDate, Gender=@Gender, Phone=@Phone, Email=@Email, 
                         CountryId=@CountryId, Address=@Address, ImagePath=@ImagePath 
                     WHERE Id=@Id;";

            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@Id", Id);
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@BirthDate", BirthDate);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@CountryId", CountryId);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@ImagePath", !string.IsNullOrWhiteSpace(ImagePath) ? ImagePath : (object)DBNull.Value);

                    try
                    {
                        connection.Open();
                        RowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Log or handle the exception as necessary
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            return RowsAffected > 0;
        }
        static public bool GetPersonById(int Id, ref String Name, ref DateTime BirthDate, ref string Gender, ref string Phone, ref string Email, ref int CountryId, ref string Address, ref string ImagePath)
        {
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"select * from Persons where Id =@Id";

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
                    Id = (int)reader["Id"];
                    Name = (string)reader["Name"];
                    BirthDate = (DateTime)reader["BirthDate"];
                    Gender = (string)reader["Gender"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    CountryId = (int)reader["CountryId"];
                    Address = (string)reader["Address"];
                    ImagePath = (reader["ImagePath"] != DBNull.Value) ? (string)reader["ImagePath"] : string.Empty;
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
        static public int GetPersonIdByName(string name)
        {
            int idPerson = 0;
            string query = @"select Id from Persons where Name=@name  SELECT SCOPE_IDENTITY();";
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            idPerson = insertedID;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log or handle the exception as needed
                    }
                }
            }
            return idPerson;
        }
        static public bool Exist(int Id)
        {
            return GenericData.Exist("select Found=1 from Persons where Id =@Id", "@Id", Id);
        }

    }
}
