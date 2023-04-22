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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace OutpatientWorkstation.BusinessLogicLayer
{
    public  class UserBll:IUserBll
    {
        /// <summary>
        /// 用户(数据访问层)
        /// </summary>
        private IUserDal UserDal { get; set; }
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
 
        public DataSet DataSet { get; set; }
        public DataTable DepartmentTable { get; set; }
        public DataTable TechnicalOfficeTable { get; set; }
        public DataTable AgencyTable { get; set; }
        public DataTable AgencyTypeTable { get; set; }

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
        /// 处理用户已存在
        /// </summary>
        /// <param name="user"></param>
        /// <exception cref="ApplicationException"></exception>
        private void HandleUserExist(User user)
        {
            if (user != null || user.Password!=null)
            {
                string errorMessage = "该用户已存在！";
                throw new ApplicationException(errorMessage);
            }
        }
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
                this.HandleUserPasswordNotMatch(user, oldPassword);
                this.CheckUserPasswordExqual(newPassword, checkPassword);
                int count=this.UserDal.UpdatePassword(userName,newPassword);
                if(count == 1)
                {
                    this.HasMpwd = true;
                    this.Message = "修改密码成功！";
                }
                else
                {
                    this.Message = "修改密码失败！";
                }
                
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
        public int SelectUserNo(string userName) 
        {
            User user = new User();
            user=this.UserDal.SelectNo(userName);
            return user.No;
        }
        public void ViewAgency()
        {
            this.DataSet=this.UserDal.SelectByTree();
            this.DepartmentTable = this.DataSet.Tables[0];
            this.TechnicalOfficeTable = this.DataSet.Tables[1];
            DataRelation[] dataRelations =
            {
                new DataRelation
                ("Department_TechnicalOffice",
                this.DepartmentTable.Columns["No"],
                this.TechnicalOfficeTable.Columns["DepartmentNo"])
            };
            this.DataSet.Relations.AddRange(dataRelations);
            
        }
        public void AfterSelect(int technicalOfficeNo)
        {
            this.AgencyTable =this.UserDal.SelectAgencyTable(technicalOfficeNo);
            this.AgencyTypeTable= this.UserDal.SelectAgencyTypeTable();
            
        }
        public void InsertAgencyInfo()
        {
            this.AgencyTypeTable = this.UserDal.SelectAgencyTypeTable();
            this.TechnicalOfficeTable=this.UserDal.SelectTechnicalOfficeNoTable();
        }
        public void InsertAgency(int agencyTypeNo, string name, bool gender, string phone, int technicalOfficeNo, string remark)
        {
            int count = this.UserDal.InsertAgency(agencyTypeNo, name, gender, phone, technicalOfficeNo, remark);
            if (count == 1)
            {
                this.Message="信息录入成功！";
            }
            else
            {
                this.Message="信息录入失败！";
            }
        }
    }
}
