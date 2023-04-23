using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OutpatientWorkstation.DataAccessLayer;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace OutpatientWorkstation.BusinessLogicLayer
{
    public  class AdminBll:IAdminBll
    {
        /// <summary>
        /// 用户数据访问层
        /// </summary>
        private IAdminDal AdminDal { get; set; }
        public AdminBll()
        {
            this.AdminDal=new AdminDal();
        }
        /// <summary>
        /// 是否完成登录
        /// </summary>
        public bool HasLoggedIn { get; private set; }
        public string OldPassword { get; set; }
        /// <summary>
        /// 新密码
        /// </summary>
        public string NewPassword { get; set; }
        /// <summary>
        /// 确认密码
        /// </summary>
        public string CheckPassword { get; set; }
        /// <summary>
        /// 验证消息
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 用户类型
        /// </summary>
        public int AgencyTypeNo { get; set; }
        /// <summary>
        /// 科室
        /// </summary>
        public int TechnicalOfficeNo { get; set; }
        /// <summary>
        /// 用户姓名
        /// </summary>
        public string AgencyName { get; set; }
        /// <summary>
        /// 用户性别
        /// </summary>
        public bool AgencyGender { get; set; }
        /// <summary>
        /// 用户电话
        /// </summary>
        public string AgencyPhone { get; set; }
        /// <summary>
        /// 用户备注
        /// </summary>
        public string AgencyRemark { get; set; }
        /// <summary>
        /// 用户类型表格
        /// </summary>
        public DataTable AgencyTypeTable { get; set; }
        /// <summary>
        /// 科室表格
        /// </summary>
        public DataTable TechnicalOfficeTable { get; set; }
        /// <summary>
        /// 用户表格
        /// </summary>
        public DataTable AgencyTable { get; set; }
        public DataSet AgencySet { get; set; }
        public DataRelation[] dataRelations { get; set; }
        /// <summary>
        /// 病人姓名
        /// </summary>
        public string PatientName { get; set; }
        /// <summary>
        /// 病人出生日期
        /// </summary>
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// 病人性别
        /// </summary>
        public bool PatientGender { get; set; }
        /// <summary>
        /// 病人电话
        /// </summary>
        public string PatientPhone { get; set; }
        /// <summary>
        /// 病人住址
        /// </summary>
        public string PatientAdress { get; set; }
        /// <summary>
        /// 病人表格
        /// </summary>
        public DataTable PatientTable { get; set; }
        public DataView PatientViewByName { get; set; }
        /// <summary>
        /// 搜索病人视图（根据名称）
        /// </summary>
        public DataTable ResultTable { get; set; }
        /// <summary>
        /// 药物表格
        /// </summary>
        public DataTable MedicineTable;
        /// <summary>
        /// 单位表格
        /// </summary>
        public DataTable UnitTable { get; set; }
        /// <summary>
        /// 药物页数视图
        /// </summary>
        public DataView MedicineViewByName { get; set; }
        /// <summary>
        /// 当前页数视图
        /// </summary>
        public DataView CurrentPageView { get; set; }
        /// <summary>
        /// 页数大小
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 当前页数
        /// </summary>
        public int CurrentPageNo { get; set; }
        /// <summary>
        /// 最大页数
        /// </summary>
        public int MaxPageNo { get; set; }
        /// <summary>
        /// 影响行数
        /// </summary>
        public int RowAffected { get; set; }
        public bool HasMpwd { get; set; }
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="plaintText"></param>
        /// <returns></returns>
        private byte[] Md5(string plainText)
        {
            byte[] plaintBytes = Encoding.Default.GetBytes(plainText);
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
        /// <param name="admin"></param>
        /// <exception cref="ApplicationException"></exception>
        private void HandleAdminNotExist(Admin admin)
        {
            if (admin == null)
            {
                string errorMessage = "该用户不存在！";
                throw new ApplicationException(errorMessage);
            }
        }
        /// <summary>
        /// 检查密码是都一致
        /// </summary>
        /// <param name="password"></param>
        /// <param name="checkPassword"></param>
        /// <exception cref="ApplicationException"></exception>
        private void CheckAdminPasswordExqual(string password, string checkPassword)
        {
            bool isPasswordCheck = Equals(password, checkPassword);
            if (!isPasswordCheck)
            {
                string errorMessage = "密码不一致，请重新输入！";
                throw new ApplicationException(errorMessage);
            }
        }
        /// <summary>
        /// 处理用户密码错误
        /// </summary>
        /// <param name="admin"></param>
        /// <param name="password"></param>
        /// <exception cref="ApplicationException"></exception>
        private void HandleAdminPasswordNotMatch(Admin admin, string password)
        {
            bool isPasswordMatch = this.Md5Equal(admin.Password, password);
            if (!isPasswordMatch)
            {
                string errorMessage = "密码错误，请重新输入！";
                throw new ApplicationException(errorMessage);
            }
        }
        /// <summary>
        /// 处理用户登录成功
        /// </summary>
        /// <param name="admin"></param>
        private void HandleAdminLoginOk(Admin admin)
        {
            this.HasLoggedIn = true;
            this.Message = "登录成功！";
        }
        /// <summary>
        /// 检查是否存在
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public bool CheckExist(string adminName)
        => this.AdminDal.SelectCount(adminName) == 1;
        /// <summary>
        /// 检查是否不存在
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public bool CheckNotExist(string userName)
            => !this.CheckExist(userName);
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Admin LogIn(string adminName,string password)
        {
           this.HasLoggedIn= false;
            Admin admin = this.AdminDal.Select(adminName);
            try    
            {
                this.HandleAdminNotExist(admin);
                this.HandleAdminPasswordNotMatch(admin,password);
                this.HandleAdminLoginOk(admin);

            }
            catch (ApplicationException ex)
            {
                this.Message = ex.Message;
            }
            catch(Exception)
            {
                this.Message = "登录失败！";
            }
            return admin;
        }
        public void ModifyPassword(string name, string oldPassword, string newPassword, string checkPassword)
        {
            this.HasMpwd = false;
            Admin admin = this.AdminDal.Select(name);
            try
            {
                this.HandleAdminPasswordNotMatch(admin, oldPassword);
                this.CheckAdminPasswordExqual(newPassword, checkPassword);
                int count = this.AdminDal.UpdatePassword(name, newPassword);
                if (count == 1)
                {
                    this.HasMpwd = true;
                    this.Message = "修改密码成功！";
                }
                else
                {
                    this.Message = "修改密码失败！";
                }

            }
            catch (ApplicationException ex)
            {
                this.Message = $"{ex.Message}\n修改密码失败！";
            }
            catch (Exception)
            {
                this.Message = "修改密码失败！";
            }
        }
        
    }
}
