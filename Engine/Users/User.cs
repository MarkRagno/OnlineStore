using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Engine.Users
{
    public class User
    {

        public string FirstName { get; set; }

        public void Register()
        {
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["OnlineStoreConnection"].ConnectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    var script = "INSERT INTO Users (FirstName, LastName, Password, CreatedDate)";
                    script += "VALUES (@firstName, @lastName, @password, @date)";
                    cmd.CommandText = script;
                    cmd.Parameters.AddWithValue("@firstName", "Ryan");
                    cmd.Parameters.AddWithValue("@lastName", "Morrow");
                    cmd.Parameters.AddWithValue("@password", "Morrow");
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);

                    cmd.Connection = conn;
                    conn.Open();

                    cmd.ExecuteNonQuery();


                }
            }
        }


    }
}
