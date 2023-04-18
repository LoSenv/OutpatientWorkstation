using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OutpatientWorkstation.DataAccessLayer;
using System.Security.Cryptography;

namespace OutpatientWorkstation.BusinessLogicLayer
{
    public  class UserBll:IUserBll
    {
        /// <summary>
        /// 用户(数据访问层)
        /// </summary>
        private UserDal UserDal { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        public UserBll()
        {
            this.UserDal = new UserDal();
        }
        /// <summary>
        /// 用户类型编号
        /// </summary>
        public int AgencyTypeNo { get; set; }
        /// <summary>
        /// 是否完成登录
        /// </summary>
        public bool HasLoggedIn { get; private set; }
        /// <summary>
        /// 是否完成注册
        /// </summary>
        public bool HasSignedUp { get; private set; }
        /// <summary>
        /// 是否完成修改密码
        /// </summary>
        public bool HasMpwd { get;private set; }
        /// <summary>
        /// 消息；
        /// </summary>
        public string Message { get; private set; }
        /// <summary>
        /// 药品表
        /// </summary>
        public DataTable MedicineTable { get; set; }
        /// <summary>
        /// 处方清单表
        /// </summary>
        public DataTable ListTable { get; set; }
        /// <summary>
        /// 病人编号
        /// </summary>
        public int PatientNo { get; set; }
        /// <summary>
        /// 处方编号
        /// </summary>
        public int OrdonnanceNo { get; set; }
        /// <summary>
        /// 员工编号
        /// </summary>
        public int AgencyNo { get; set; }
        /// <summary>
        /// 用药方法表
        /// </summary>
        public DataTable useMethodTable { get; set; }
        /// <summary>
        /// 用药频率表
        /// </summary>
        public DataTable useFrequencyTable { get; set; }

        public int Result { get; set; }
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="plaintText"></param>
        /// <returns></returns>
        private byte[] Md5(string plainText)
        {
            byte[] plaintBytes=Encoding.Default.GetBytes(plainText);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] cryptedBytes = md5.ComputeHash(plaintBytes);
            return cryptedBytes;
        }
        /// <summary>
        /// MD5值是否相等
        /// </summary>
        /// <param name="md5"></param>
        /// <param name="otherPlainText"></param>
        /// <returns></returns>
        private bool Md5Equal(byte[] md5, string otherPlainText)
            => md5.SequenceEqual(this.Md5(otherPlainText));
        /// <summary>
        /// 处理用户是否存在
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        /// <exception cref="ApplicationException"></exception>
        private void HandleUserNotExist(User user)
        {
            if (user == null)
            {
                string errorMessage = "该用户不存在！";
                throw new ApplicationException(errorMessage);
            }
        }
        /// <summary>
        /// 检查用户类型
        /// </summary>
        /// <param name="user"></param>
        private void CheckUserType(User user)
        {
            this.AgencyTypeNo= user.AgencyTypeNo;
        }
        /// <summary>
        /// 检查密码是都一致
        /// </summary>
        /// <param name="user"></param>
        /// <param name="checkPassword"></param>
        /// <exception cref="ApplicationException"></exception>
        private void CheckUserPasswordExqual(string password, string checkPassword)
        {
            bool isPasswordCheck=Equals(password, checkPassword);
            if(!isPasswordCheck)
            {
                string errorMessage = "密码不一致，请重新输入！";
                throw new ApplicationException(errorMessage);
            }
        }
        /// <summary>
        /// 确认密码
        /// </summary>
        /// <param name="newPassword"></param>
        /// <param name="checkPassword"></param>
        /// <returns></returns>
        private bool CheckPassowrd(string newPassword,string checkPassword)
        {
            bool isPasswordCheck = Equals(newPassword, checkPassword);
            if(!isPasswordCheck)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// 处理用户密码错误
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <exception cref="ApplicationException"></exception>
        private void HandleUserPasswordNotMatch(User user, string password)
        {
            bool isPasswordMatch=this.Md5Equal(user.Password, password);
            if(!isPasswordMatch)
            {
                string errorMessage = "密码错误，请重新输入！";
                throw new ApplicationException(errorMessage);
            }
        }
        /// <summary>
        /// 处理用户登录成功
        /// </summary>
        /// <param name="user"></param>
        private void HandleUserLoginOk(User user)
        {
            this.HasLoggedIn= true;
            this.Message = "登录成功！";
        }
        /// <summary>
        /// 处理用户注册成功
        /// </summary>
        /// <param name="user"></param>
        private void HandleUserSignOk(User user)
        {
            this.HasSignedUp= true;
            this.Message = "注册成功！";
        }
        /// <summary>
        /// 检查是否存在
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public bool CheckExist(string userName)
        => this.UserDal.SelectCount(userName) == 1;
        /// <summary>
        /// 检查是否不存在
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public bool CheckNotExist(string userName)
            =>!this.CheckExist(userName);
        /// <summary>
        /// 确认密码一致
        /// </summary>
        /// <param name="newPassword"></param>
        /// <param name="checkPassword"></param>
        /// <returns></returns>
        public bool CheckEqual(string newPassword,string checkPassword)
            =>this.CheckPassowrd(newPassword, checkPassword);
        /// <summary>
        /// 确认密码不一致
        /// </summary>
        /// <param name="newPassword"></param>
        /// <param name="checkPassword"></param>
        /// <returns></returns>
        public bool CheckNotEqual(string newPassword,string checkPassword)
            =>!this.CheckEqual(newPassword,checkPassword);
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public User LogIn(string userName,string password)
        {
            this.HasLoggedIn = false;
            User user = this.UserDal.Select(userName);
            try
            {
                this.HandleUserNotExist(user);
                this.HandleUserPasswordNotMatch(user, password);
                this.HandleUserLoginOk(user);
                this.CheckUserType(user);
            }
            catch(ApplicationException ex)
            {
                this.Message = ex.Message;
            }
            catch (Exception)
            {
                this.Message = "登录失败！";
            }
            return user;
        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public User SignUp(string userName, string password,string checkPassword)
        {
            this.HasSignedUp = false;
            User user = new User()
            {
                Name = userName,
                Password = Md5(password)
            };
            try
            {
                this.CheckUserPasswordExqual(password,checkPassword);
                this.UserDal.InsertUser(user);
                this.HasSignedUp = true;
                this.Message = "注册成功！";
            }
            catch(ApplicationException ex)
            {
                this.Message = $"{ex.Message}\n注册失败！";
            }
            catch(Exception)
            {
                this.Message = "注册失败！";
            }
            return user;
        }
        public User ModifyPassword(string userName,string oldPassword,string newPassword,string checkPassword)
        {
            this.HasMpwd= false;
            User user =this.UserDal.Select(userName);
            try
            {
                bool isPasswordMatch = this.Md5Equal(user.Password, oldPassword);
                if (!isPasswordMatch)
                {
                    string errorMessage = "旧密码错误，请重新输入！";
                    throw new ApplicationException(errorMessage);
                }
                user.Password = Md5(oldPassword);
                this.UserDal.UpdatePassword(user);
                this.HasMpwd = true;
                this.Message = "修改密码成功！";
            }
            catch(ApplicationException ex)
            {
                this.Message= $"{ex.Message}\n修改密码失败！";
            }
            catch (Exception)
            {
                this.Message = "修改密码失败！";
            }
            return user;
        }


        //public void LoadAgencyNo()
        //{
        //    SqlConnection sqlConnection = new SqlConnection();
        //    sqlConnection.ConnectionString =
        //        ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
        //    SqlCommand sqlCommand = new SqlCommand();
        //    sqlCommand.Connection = sqlConnection;
        //    sqlCommand.CommandText = "SELECT No FROM tb_Agency WHERE Name=@Name";
        //    sqlCommand.Parameters.AddWithValue("@Name", this.Name);
        //    sqlConnection.Open();
        //    SqlDataReader reader = sqlCommand.ExecuteReader();
        //    if (reader.Read())
        //    {
        //        this.AgencyNo = (int)reader["No"];
        //    }
        //    sqlConnection.Close();
        //}
        //public void InsertOrdonnance()
        //{
        //    SqlConnection sqlConnection = new SqlConnection();
        //    sqlConnection.ConnectionString =
        //        ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
        //    SqlCommand insertCommand = new SqlCommand();
        //    SqlCommand insertDetailCommand = new SqlCommand();
        //    insertCommand.Connection = sqlConnection;
        //    insertCommand.CommandText = "INSERT INTO tb_Ordonnance " +
        //        "(No,PatientNo,AgencyNo,Date)" +
        //        "VALUES(@No,@PatientNo,@AgencyNo,@Date)";
        //    insertCommand.Parameters.AddWithValue("@No", this.OrdonnanceNo);
        //    insertCommand.Parameters.AddWithValue("@PatientNo", this.PatientNo);
        //    insertCommand.Parameters.AddWithValue("@AgencyNo", this.AgencyNo);
        //    insertCommand.Parameters.AddWithValue("@Date", DateTime.Now.Date.ToString());
        //    sqlConnection.Open();
        //    int rowAffected = 0;
        //    try
        //    {
        //        rowAffected = insertCommand.ExecuteNonQuery();
        //    }
        //    catch (SqlException sqlEx)
        //    {
        //        MessageBox.Show(sqlEx.Message);
        //    }
        //    if (rowAffected == 1)
        //    {
        //        this.Message = "新增处方成功！";
        //    }
        //    else
        //    {
        //        this.Message = "新增处方失败！";
        //    }
        //    sqlConnection.Close();
        //}
        //public void LoadOrdonnance()
        //{
        //    SqlConnection sqlConnection = new SqlConnection();
        //    sqlConnection.ConnectionString =
        //        ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
        //    SqlCommand sqlCommand = new SqlCommand();
        //    sqlCommand.Connection = sqlConnection;
        //    sqlCommand.CommandText = "SELECT * FROM tb_Medicine";
        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        //    sqlDataAdapter.SelectCommand = sqlCommand;
        //    this.MedicineTable = new DataTable();
        //    this.ListTable = new DataTable();
        //    this.useMethodTable = new DataTable();
        //    this.useFrequencyTable = new DataTable();
        //    sqlConnection.Open();
        //    sqlDataAdapter.Fill(this.MedicineTable);
        //    sqlCommand.CommandText =
        //       @"SELECT OD.Type,OD.Encod,OD.MedicineNo,M.Name,OD.TotalDrug,OD.EachAgent,OD.UseMethodNo,OD.UseFrequencyNo,OD.Remark
        //        FROM tb_OrdonnanceDetail AS OD
        //        JOIN tb_Medicine AS M ON M.No=OD.MedicineNo
        //        WHERE OD.OrdonnanceNo=@OrdonnanceNo";
        //    sqlCommand.Parameters.AddWithValue("@OrdonnanceNo", this.OrdonnanceNo);
        //    sqlDataAdapter.Fill(this.ListTable);
        //    sqlCommand.CommandText =
        //        "SELECT* FROM tb_UseMethod";
        //    sqlDataAdapter.Fill(useMethodTable);
        //    sqlCommand.CommandText =
        //        "SELECT* FROM tb_UseFrequency";
        //    sqlDataAdapter.Fill(useFrequencyTable);
        //    sqlConnection.Close();
        //}
        //public void InsertDrug()
        //{
        //    if (this.OrdonnanceNo.ToString() == null)
        //    {
        //        MessageBox.Show("处方号为空，请新建处方！");
        //        return;
        //    }
        //    else
        //    {
        //        SqlConnection sqlConnection = new SqlConnection();
        //        sqlConnection.ConnectionString =
        //            ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
        //        SqlCommand insertCommand = new SqlCommand();
        //        insertCommand.Connection = sqlConnection;
        //        insertCommand.CommandText = "INSERT INTO tb_OrdonnanceDetail" +
        //            "(OrdonnanceNo,Type,Encod,MedicineNo,TotalDrug,EachAgent,UseMethodNo,UseFrequencyNo,Remark)" +
        //            "values(@OrdonnanceNo,@Type,@Encod,@MedicineNo,@TotalDrug,@EachAgent,@UseMethodNo,@UseFrequencyNo,@Remark)";
        //        insertCommand.Parameters.AddWithValue("@OrdonnanceNo", this.OrdonnanceNo);
        //        insertCommand.Parameters.Add("@Type", SqlDbType.VarChar, 0, "Type");
        //        insertCommand.Parameters.Add("@Encod", SqlDbType.VarChar, 0, "Encod");
        //        insertCommand.Parameters.Add("@MedicineNo", SqlDbType.Int, 0, "MedicineNo");
        //        insertCommand.Parameters.Add("@TotalDrug", SqlDbType.VarChar, 0, "TotalDrug");
        //        insertCommand.Parameters.Add("@EachAgent", SqlDbType.VarChar, 0, "EachAgent");
        //        insertCommand.Parameters.Add("@UseMethodNo", SqlDbType.Int, 0, "UseMethodNo");
        //        insertCommand.Parameters.Add("@UseFrequencyNo", SqlDbType.Int, 0, "UseFrequencyNo");
        //        insertCommand.Parameters.Add("@Remark", SqlDbType.VarChar, 0, "Remark");
        //        SqlCommand deleteCommand = new SqlCommand();
        //        deleteCommand.Connection = sqlConnection;
        //        deleteCommand.CommandText = "DELETE tb_OrdonnanceDetail WHERE Encod=@Encod";
        //        deleteCommand.Parameters.Add("@Encod", SqlDbType.VarChar, 0, "Encod");
        //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        //        sqlDataAdapter.InsertCommand = insertCommand;
        //        sqlDataAdapter.DeleteCommand = deleteCommand;
        //        sqlConnection.Open();
        //        int rowAffected = sqlDataAdapter.Update(ListTable);
        //        sqlConnection.Close();
        //        MessageBox.Show($"更新{rowAffected}行");
        //    }
        //}
    }
}
