using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicSystemDataAccess
{
    public class UserData
    {
        static public int Add(string username, string password, int Permission, int PersonId)
        {
            int NewIdCustomer = 0;
            string query = @"insert into Users (UserName,password,Permission,PersonId) 
                        values (@username,@password,@Permission,@PersonId)
                           SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@Permission", Permission);
                    command.Parameters.AddWithValue("@PersonId", PersonId);
                    try
                    {
                        connection.Open();
                        object Result = command.ExecuteScalar();
                        if (Result != null && int.TryParse(Result.ToString(), out int insertedId))
                        {
                            NewIdCustomer = insertedId;
                        }
                    }
                    catch (Exception ex) { }
                }
            }
            return NewIdCustomer;
        }
        static public bool Update(int Id, string username, string password, int Permission, int PersonId)
        {
            int RowAffected = 0;
            string query = @"   update Users set UserName=@username , password=@password,Permission=@Permission,PersonId=@PersonId
				   where Id=@Id;";

            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@Permission", Permission);
                    command.Parameters.AddWithValue("@PersonId", PersonId);
                    command.Parameters.AddWithValue("@Id", Id);
                    try
                    {
                        connection.Open();
                        RowAffected = command.ExecuteNonQuery();
                    }
                    catch { Exception exception; }
                }
            }
            return RowAffected > 0;
        }
        static public bool Delete(int Id)
        {
            return GenericData.Delete("Delete Users where Id=@Id", "@Id", Id);
        }
        static public DataTable All()
        {
            return GenericData.All("select * from View_Users_Details");
        }
        static public bool GetUserByUsernameAndPassword(ref int PersonId, ref int Id, string Username, string Password, ref int Permission)
        {
            string query = @"select * from Users where UserName=@username and Password=@Password";

            bool IsFound = false;

            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", Username);
                    command.Parameters.AddWithValue("@Password", Password);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            IsFound = true;
                            Id = (int)reader["Id"];
                            PersonId = (int)reader["Person Id"];
                            Permission = (int)reader["Permission"];
                        }
                        else
                        {
                            IsFound = false;
                        }
                    }
                    catch { Exception exception; }
                }
            }
            return IsFound;
        }
        static public bool GetUserByUserName(ref int PersonId, ref int Id, string username, ref string Password, ref int Permission)
        {
            string query = @"select * from Users where UserName=@username";

            bool IsFound = false;

            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", username);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                Id = (int)reader["Id"];
                                PersonId = (int)reader["PersonId"];
                                Password = (string)reader["Password"];
                                Permission = (int)reader["Permission"];
                            }
                            else
                            {
                                IsFound = false;
                            }
                        }

                    }
                    catch { Exception exception; }
                }
            }
            return IsFound;
        }
        static public bool GetUserById(ref int PersonId, int Id, ref string username, ref string Password, ref int Permission)
        {
            string query = @"select * from Users where Id=@Id";
            bool IsFound = false;
            using (SqlConnection connection = new SqlConnection(SettingData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            IsFound = true;
                            username = (string)reader["UserName"];
                            PersonId = (int)reader["PersonId"];
                            Password = (string)reader["Password"];
                            Permission = (int)reader["Permission"];
                        }
                        else
                        {
                            IsFound = false;
                        }

                    }
                    catch { Exception exception; }
                }
            }
            return IsFound;
        }
        static public bool Exist(int Id)
        {
            return GenericData.Exist("select Found=1 from Users where Id =@Id", "@Id", Id);
        }
        static public bool ExistByUserName(string UserName)
        {
            return GenericData.Exist("select Found=1 from Users where UserName=@UserName", "@UserName", UserName);
        }
    }
}
