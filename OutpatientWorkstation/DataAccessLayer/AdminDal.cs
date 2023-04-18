using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutpatientWorkstation.DataAccessLayer
{
    public  class AdminDal:IAdminDal
    {
        public Admin Select(string adminName)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText =
                $@"SELECT *
				FROM tb_Admin
                WHERE 
				Name=@Name";
            sqlCommand.Parameters.AddWithValue("@Name", adminName);
            sqlConnection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            Admin admin = new Admin();
            if(reader.Read())
            {
                admin = new Admin()
                {
                    Name = reader["Name"].ToString(),
                    Password = (byte[])reader["Password"],
                };
            }
            reader.Close();
            return admin;
        }
        public int SelectCount(string adminName)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText =
                $@"SELECT COUNT(1) 
				FROM tb_Admin
                WHERE 
				Name=@Name";
            sqlCommand.Parameters.AddWithValue("@Name", adminName);
            sqlConnection.Open();
            int count = (int)sqlCommand.ExecuteScalar();
            sqlConnection.Close();
            return count;
        }
    }
}
