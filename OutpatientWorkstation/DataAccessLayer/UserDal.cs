﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OutpatientWorkstation.DataAccessLayer
{
    /// <summary>
    /// 用户（数据访问层）
    /// </summary>
    public class UserDal:IUserDal
    {
        /// <summary>
        /// 查询用户
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public User Select(string username)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection= sqlConnection;
            sqlCommand.CommandText = @"SELECT *
                FROM tb_Agency
                WHERE Name=@Name";
            sqlCommand.Parameters.AddWithValue("@Name", username);
            sqlConnection.Open();
            SqlDataReader reader=sqlCommand.ExecuteReader();
            User user= new User();
            if(reader.Read())
            {
                user = new User()
                {
                    Name = reader["Name"].ToString(),
                    Password = (byte[])reader["Password"],
                    TechnicalOfficeNo = (int)reader["TechnicalOfficeNo"],
                    AgencyTypeNo = (int)reader["AgencyTypeNo"],
                    Remark = reader["Remark"].ToString()
                };
            }
            reader.Close();
            return user;
        }
        /// <summary>
        /// 查询用户计数
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public int SelectCount(string userName)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ToString();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = @"SELECT COUNT(1)
                FROM tb_Agency
                WHERE Name=@Name";
            sqlCommand.Parameters.AddWithValue("@Name", userName);
            sqlConnection.Open();
            int count = (int)sqlCommand.ExecuteScalar();
            sqlConnection.Close();
            return count;
        }
        /// <summary>
		/// 插入用户；
		/// </summary>
		/// <param name="user">用户</param>
		/// <returns>受影响行数</returns>
		public int InsertUser(User user)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ToString();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = @"UPDATE tb_Agency
				SET Password=@Password
				WHERE Name=@Name";
            sqlCommand.Parameters.AddWithValue("@Name", user.Name);
            sqlCommand.Parameters.AddWithValue("@Password", user.Password);
            int rowAffected = 0;
            try
            {
                sqlConnection.Open();
                rowAffected = sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2627)
                {
                    throw new ApplicationException("您提交的用户名已存在");
                }
                throw sqlEx;
            }
            finally
            {
                sqlConnection.Close();
            }
            return rowAffected;
        }
        public int UpdatePassword(string userName,string password)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText =
                $@"UPDATE tb_Agency
                SET Password=HASHBYTES('MD5',@Password)
                WHERE Name=@Name";
            sqlCommand.Parameters.AddWithValue("@Name", userName);
            sqlCommand.Parameters.AddWithValue("@Password", password);
            sqlCommand.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;
            int rowAffected = 0;
            sqlConnection.Open();
            rowAffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return rowAffected;
        }
        public User SelectNo(string userName)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT No FROM tb_Agency WHERE Name=@Name";
            sqlCommand.Parameters.AddWithValue("@Name", userName);
            sqlConnection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            User user = new User();
            if (reader.Read())
            {
                user = new User()
                {
                    No = (int)reader["No"]
                };
            }
            reader.Close();
            return user;
        }
        public DataSet SelectByTree() 
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText =
                "SELECT * FROM tb_Department;" +
                "SELECT * FROM tb_TechnicalOffice;";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataSet dataSet = new DataSet();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataSet);
            sqlConnection.Close();
            return dataSet;
        }
        public DataTable SelectAgencyTable(int technicalOfficeNo)
        {
            
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText =
               $@"SELECT No,Name,Gender,Phone,AgencyTypeNo,Remark 
                FROM tb_Agency WHERE TechnicalOfficeNo=@TechnicalOfficeNo";
            sqlCommand.Parameters.AddWithValue("@TechnicalOfficeNo", technicalOfficeNo);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable AgencyTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(AgencyTable);
            sqlConnection.Close();
            return AgencyTable;
        }
        public DataTable SelectAgencyTypeTable()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT * FROM tb_AgencyType";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable agencyTypeTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(agencyTypeTable);
            sqlConnection.Close();
            return agencyTypeTable;
        }
     public DataTable SelectTechnicalOfficeNoTable()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT No,Name FROM tb_TechnicalOffice";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable technicalOfficeTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(technicalOfficeTable);
            sqlConnection.Close();
            return technicalOfficeTable;
        }
        public int InsertAgency(int agencyTypeNo,string name,bool gender,string phone,int technicalOfficeNo,string remark)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText =
                $@"INSERT INTO tb_Agency(AgencyTypeNo,Name,Gender,Phone,TechnicalOfficeNo,Remark)
                VALUES(@AgencyTypeNo,@Name,@Gender,@Phone,@TechnicalOfficeNo,@Remark)";
            sqlCommand.Parameters.AddWithValue("@AgencyTypeNo", agencyTypeNo);
            sqlCommand.Parameters.AddWithValue("@Name", name);
            sqlCommand.Parameters.AddWithValue("@Gender", gender);
            sqlCommand.Parameters.AddWithValue("@Phone", phone);
            sqlCommand.Parameters.AddWithValue("@TechnicalOfficeNo", technicalOfficeNo);
            sqlCommand.Parameters.AddWithValue("@Remark", remark);
            sqlConnection.Open();
            int rowCount = (int)sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return rowCount;
        }
    }
}
