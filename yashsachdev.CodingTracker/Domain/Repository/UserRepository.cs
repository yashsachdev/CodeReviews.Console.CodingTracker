using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yashsachdev.CodingTracker.Domain.Interface;
using yashsachdev.CodingTracker.Domain.Model;

namespace yashsachdev.CodingTracker.Domain.Repository
{
    internal class UserRepository : IuserRepo
    {
        private string _connectionString = ;

        public User AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int userId)
        {
            throw new NotImplementedException();
        }

        public User GetUser(int userId)
        {
            using (SqlConnection cnn = new SqlConnection())
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(_connectionString))
                {
                    cmd.Connection = cnn;
                    string sqlQuery = "SELECT * FROM User WHERE UserId = @UserId";
                    cmd.CommandText = sqlQuery;
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    User user = null;
                    using (SqlDataReader reader = cmd.ExecuteReader()) 
                    {
                        while(reader.Read())
                        {
                            user = new User
                            { userId = Convert.ToInt32(reader["userId"]),
                              userName = reader["userName"].ToString(),
                                sessions = GetSessionsByUser(Convert.ToInt32(reader["userId"])
                            };


                        }
                    }
                }
            }
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
