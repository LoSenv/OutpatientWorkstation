using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutpatientWorkstation
{
    public class User
    {
        /// <summary>
        /// 用户号；
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 密码；
        /// </summary>
        public string Password { private get; set; }
        /// <summary>
        /// 消息；
        /// （用于返回验证结果）
        /// </summary>
        public string Message { get; private set; }
        /// <summary>
        /// 登录；
        /// </summary>
        /// <returns>是否完成登录</returns>
        public int Result { get; set; }
        public bool LogIn()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            SqlCommand sqlCommand1 = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand1.Connection = sqlConnection;
            sqlCommand.CommandText =
                $@"SELECT COUNT(1) 
				FROM tb_Agency
                WHERE 
				Name=@Name
                AND Password=HASHBYTES('MD5',@Password)";
            sqlCommand1.CommandText =
                $@"SELECT AgencyTypeNo 
                FROM tb_Agency
                WHERE Name=@Name";
            sqlCommand.Parameters.AddWithValue("@Name", this.Name);
            sqlCommand.Parameters.AddWithValue("@Password", this.Password);
            sqlCommand.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;
            sqlCommand1.Parameters.AddWithValue("@Name", this.Name);
            sqlConnection.Open();
            int rowCount = (int)sqlCommand.ExecuteScalar();
            this.Result = (int)sqlCommand1.ExecuteScalar();
            sqlConnection.Close();
            bool hasLoggedIn = false;
            if (rowCount == 1)
            {
                hasLoggedIn = true;
                this.Message = "登录成功。";
            }
            else
            {
                hasLoggedIn = false;
                this.Message = "用户号/密码有误，请重新输入！";
            }
            return hasLoggedIn;
        }
        public bool SignUp(string name,string password,string check)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            SqlCommand sqlCommand1 = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand1.Connection = sqlConnection;
            sqlCommand.CommandText =
                $@"SELECT COUNT(1) 
				FROM tb_Agency
                WHERE 
				Name='{name}'";
            sqlCommand1.CommandText =
                $@"UPDATE tb_Agency
				SET Password=HASHBYTES('MD5',@Password)
				WHERE Name=@Name";
            bool hasSignup=false;
            sqlConnection.Open();
            int rowCount = (int)sqlCommand.ExecuteScalar();
            if (rowCount == 1)
            {
                if (password == check)
                {
                    sqlCommand1.Parameters.AddWithValue("@Name", name);
                    sqlCommand1.Parameters.AddWithValue("@Password", password);
                    sqlCommand1.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;
                    int rowAffected = 0;
                    try
                    {
                        rowAffected = sqlCommand1.ExecuteNonQuery();
                    }
                    catch (SqlException sqlEx)
                    {
                        hasSignup = false;
                        this.Message = sqlEx.Message;
                    }
                    if (rowAffected == 1)
                    {
                        hasSignup= true;
                        this.Message="注册成功！";
                    }
                    else
                    {
                        hasSignup = false;
                        this.Message = "注册失败,请联系管理员！";
                    }
                }
                else
                {
                    hasSignup = false;
                    this.Message = "两次密码不一致！";
                }
            }
            else
            {
                hasSignup=false;
                this.Message = "您的信息未录入系统，请联系管理员！";
            }
            sqlConnection.Close();
            return hasSignup;
        }
    }
}
