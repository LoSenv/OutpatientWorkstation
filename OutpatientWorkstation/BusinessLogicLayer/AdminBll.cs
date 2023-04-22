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

        ///// <summary>
        ///// 修改密码
        ///// </summary>
        ///// <returns></returns>
        //public bool ModifyPassword()
        //{
        //    SqlConnection sqlConnection = new SqlConnection();
        //    sqlConnection.ConnectionString =
        //        ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
        //    SqlCommand sqlCommand = new SqlCommand();
        //    SqlCommand sqlCommand1 = new SqlCommand();
        //    sqlCommand.Connection = sqlConnection;
        //    sqlCommand1.Connection = sqlConnection;
        //    sqlCommand.CommandText =
        //        $@"SELECT COUNT(1)
        //        FROM tb_Admin
        //        WHERE Password=HASHBYTES('MD5',@oldPassword)";
        //    sqlCommand1.CommandText =
        //        $@"UPDATE tb_Admin
        //        SET Password=HASHBYTES('MD5',@newPassword)
        //        WHERE Name=@Name";
        //    sqlCommand.Parameters.AddWithValue("@oldPassword", this.OldPassword);
        //    sqlCommand.Parameters["@oldPassword"].SqlDbType = SqlDbType.VarChar;
        //    sqlCommand1.Parameters.AddWithValue("@Name", this.Name);
        //    sqlCommand1.Parameters.AddWithValue("@newPassword", this.NewPassword);
        //    sqlCommand1.Parameters["@newPassword"].SqlDbType = SqlDbType.VarChar;
        //    sqlConnection.Open();
        //    int rowcount = (int)sqlCommand.ExecuteScalar();
        //    bool hasModify = false;
        //    if (rowcount == 1)
        //    {
        //        if (this.NewPassword == this.CheckPassword)
        //        {

        //            int effectrow = sqlCommand1.ExecuteNonQuery();
        //            if (effectrow == 1)
        //            {
        //                hasModify = true;
        //                this.Message = "修改密码成功！";
        //            }
        //            else
        //            {
        //                hasModify = false;
        //                this.Message = "修改密码失败，请联系管理员！";
        //            }

        //        }
        //        else
        //        {
        //            hasModify = false;
        //            this.Message = "两次密码不一致，请重新输入！";
        //        }
        //    }
        //    else
        //    {
        //        hasModify = false;
        //        this.Message = "旧密码错误，请重新输入！";
        //    }
        //    sqlConnection.Close();
        //    return hasModify;
        //}

        //public void DisplayAgencyType()
        //{
        //    SqlConnection sqlConnection = new SqlConnection();
        //    sqlConnection.ConnectionString =
        //        ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
        //    SqlCommand sqlCommand = new SqlCommand();
        //    sqlCommand.Connection = sqlConnection;
        //    sqlCommand.CommandText = "SELECT * FROM tb_AgencyType";
        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        //    sqlDataAdapter.SelectCommand = sqlCommand;
        //    this.AgencyTypeTable = new DataTable();
        //    sqlConnection.Open();
        //    sqlDataAdapter.Fill(this.AgencyTypeTable);
        //    sqlConnection.Close();
        //}

        //public void DisplayTechnicalOffice()
        //{
        //    SqlConnection sqlConnection = new SqlConnection();
        //    sqlConnection.ConnectionString =
        //        ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
        //    SqlCommand sqlCommand = new SqlCommand();
        //    sqlCommand.Connection = sqlConnection;
        //    sqlCommand.CommandText = "SELECT No,Name FROM tb_TechnicalOffice";
        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        //    sqlDataAdapter.SelectCommand = sqlCommand;
        //    this.TechnicalOfficeTable = new DataTable();
        //    sqlConnection.Open();
        //    sqlDataAdapter.Fill(this.TechnicalOfficeTable);
        //    sqlConnection.Close();
        //}
        ///// <summary>
        ///// 插入员工
        ///// </summary>
        //public void InsertAgency()
        //{
        //    SqlConnection sqlConnection = new SqlConnection();
        //    sqlConnection.ConnectionString =
        //        ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
        //    SqlCommand sqlCommand = new SqlCommand();
        //    sqlCommand.Connection = sqlConnection;
        //    sqlCommand.CommandText =
        //        $@"INSERT INTO tb_Agency(AgencyTypeNo,Name,Gender,Phone,TechnicalOfficeNo,Remark)
        //        VALUES(@AgencyTypeNo,@Name,@Gender,@Phone,@TechnicalOfficeNo,@Remark)";
        //    sqlCommand.Parameters.AddWithValue("@AgencyTypeNo", this.AgencyTypeNo);
        //    sqlCommand.Parameters.AddWithValue("@Name", this.AgencyName);
        //    sqlCommand.Parameters.AddWithValue("@Gender", this.AgencyGender);
        //    sqlCommand.Parameters.AddWithValue("@Phone", this.AgencyPhone);
        //    sqlCommand.Parameters.AddWithValue("@TechnicalOfficeNo", this.TechnicalOfficeNo);
        //    sqlCommand.Parameters.AddWithValue("@Remark", this.AgencyRemark);
        //    sqlConnection.Open();
        //    int rowCount = (int)sqlCommand.ExecuteNonQuery();
        //    sqlConnection.Close();
        //    if (rowCount == 1)
        //    {
        //        this.Message = "信息录入成功！";
        //    }
        //    else
        //    {
        //        this.Message = "信息录入失败！";
        //    }
        //}

        ///// <summary>
        ///// 浏览员工
        ///// </summary>
        //public void ViewAgency()
        //{
        //    SqlConnection sqlConnection = new SqlConnection();
        //    sqlConnection.ConnectionString =
        //        ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
        //    SqlCommand sqlCommand = new SqlCommand();
        //    sqlCommand.Connection = sqlConnection;
        //    sqlCommand.CommandText = "SELECT * FROM tb_AgencyType;";
        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        //    sqlDataAdapter.SelectCommand = sqlCommand;
        //    this.AgencyTypeTable = new DataTable();
        //    this.AgencyTable = new DataTable();
        //    sqlConnection.Open();
        //    sqlDataAdapter.Fill(this.AgencyTypeTable);
        //    sqlCommand.CommandText =
        //        $@"SELECT No,Name,Gender,Phone,AgencyTypeNo,Remark
        //        FROM tb_Agency";
        //    sqlDataAdapter.Fill(this.AgencyTable);
        //    sqlConnection.Close();
        //}
        ///// <summary>
        ///// 修改员工
        ///// </summary>

        //public void ModifyAgency()
        //{
        //    SqlConnection sqlConnection = new SqlConnection();
        //    sqlConnection.ConnectionString =
        //        ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
        //    SqlCommand updateCommand = new SqlCommand();
        //    updateCommand.Connection = sqlConnection;
        //    updateCommand.CommandText =
        //        $@"UPDATE tb_Agency
        //        SET Name=@Name,Phone=@Phone,AgencyTypeNo=@AgencyTypeNo,Remark=@Remark
        //        WHERE No=@No";
        //    updateCommand.Parameters.Add("@Name", SqlDbType.VarChar, 0, "Name");
        //    updateCommand.Parameters.Add("@Gender", SqlDbType.Bit, 0, "Gender");
        //    updateCommand.Parameters.Add("@Phone", SqlDbType.Char, 10, "Phone");
        //    updateCommand.Parameters.Add("@AgencyTypeNo", SqlDbType.Int, 0, "AgencyTypeNo");
        //    updateCommand.Parameters.Add("@Remark", SqlDbType.VarChar, 0, "Remark");
        //    updateCommand.Parameters.Add("@No", SqlDbType.Int, 0, "No");
        //    SqlCommand deleteCommand = new SqlCommand();
        //    deleteCommand.Connection = sqlConnection;
        //    deleteCommand.CommandText =
        //        "DELETE tb_Agency WHERE No=@No";
        //    deleteCommand.Parameters.Add("@No", SqlDbType.Int, 0, "No");
        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        //    sqlDataAdapter.UpdateCommand = updateCommand;
        //    sqlDataAdapter.DeleteCommand = deleteCommand;
        //    DataTable dataTable = this.AgencyTable;
        //    sqlConnection.Open();
        //    this.RowAffected = sqlDataAdapter.Update(dataTable);
        //    sqlConnection.Close();
        //    this.Message = $"更新{this.RowAffected}行。";
        //}

        //public void ViewAgencyByTree()
        //{
        //    SqlConnection sqlConnection = new SqlConnection();
        //    sqlConnection.ConnectionString =
        //        ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
        //    SqlCommand sqlCommand = new SqlCommand();
        //    sqlCommand.Connection = sqlConnection;
        //    sqlCommand.CommandText =
        //        "SELECT * FROM tb_Department;" +
        //        "SELECT * FROM tb_TechnicalOffice;";
        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        //    sqlDataAdapter.SelectCommand = sqlCommand;
        //    this.AgencySet = new DataSet();
        //    sqlConnection.Open();
        //    sqlDataAdapter.Fill(this.AgencySet);
        //    sqlConnection.Close();

        //}

        //public void AfterSelect(int technicalOfficeNo)
        //{
        //    SqlConnection sqlConnection = new SqlConnection();
        //    sqlConnection.ConnectionString =
        //        ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
        //    SqlCommand sqlCommand = new SqlCommand();
        //    sqlCommand.Connection = sqlConnection;
        //    this.AgencyTable = new DataTable();
        //    this.AgencyTypeTable = new DataTable();
        //    sqlCommand.CommandText = "SELECT * FROM tb_AgencyType";
        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        //    sqlDataAdapter.SelectCommand = sqlCommand;
        //    sqlConnection.Open();
        //    sqlDataAdapter.Fill(this.AgencyTypeTable);
        //    sqlCommand.CommandText =
        //        $@"SELECT No,Name,Gender,Phone,AgencyTypeNo,Remark 
        //        FROM tb_Agency WHERE TechnicalOfficeNo=@TechnicalOfficeNo";
        //    sqlCommand.Parameters.AddWithValue("@TechnicalOfficeNo", technicalOfficeNo);
        //    sqlDataAdapter.Fill(this.AgencyTable);
        //    sqlConnection.Close();
        //}
        ///// <summary>
        ///// 插入病人
        ///// </summary>
        //public void InsertPatient()
        //{
        //    SqlConnection sqlConnection = new SqlConnection();
        //    sqlConnection.ConnectionString =
        //        ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
        //    SqlCommand sqlCommand = new SqlCommand();
        //    sqlCommand.Connection = sqlConnection;
        //    sqlCommand.CommandText =
        //        $@"INSERT INTO tb_Patient
        //        (Name,BirthDate,Gender,Phone,Adress)
        //        VALUES(@Name,@BirthDate,@Gender,@Phone,@Adress)";
        //    sqlCommand.Parameters.AddWithValue("@Name", this.PatientName);
        //    sqlCommand.Parameters.AddWithValue("@BirthDate", this.BirthDate);
        //    sqlCommand.Parameters.AddWithValue("@Gender", this.PatientGender);
        //    sqlCommand.Parameters.AddWithValue("@Phone", this.PatientPhone);
        //    sqlCommand.Parameters.AddWithValue("@Adress", this.PatientAdress);
        //    sqlCommand.Parameters["@BirthDate"].SqlDbType = SqlDbType.Date;
        //    sqlConnection.Open();
        //    int rowCount = sqlCommand.ExecuteNonQuery();
        //    if (rowCount == 1)
        //    {
        //        this.Message = "信息录入成功！";
        //    }
        //    else
        //    {
        //        this.Message = "信息录入失败！";
        //    }
        //    sqlConnection.Close();
        //}
        ///// <summary>
        ///// 浏览病人
        ///// </summary>
        //public void ViewPatient()
        //{
        //    SqlConnection sqlConnection = new SqlConnection();
        //    sqlConnection.ConnectionString =
        //        ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
        //    SqlCommand sqlCommand = new SqlCommand();
        //    sqlCommand.Connection = sqlConnection;
        //    sqlCommand.CommandText =
        //        $@"SELECT No AS 编号,Name AS 姓名,IIF(Gender=1,'男','女') AS 性别
        //        ,BirthDate AS 出生日期,Phone AS 电话,Adress AS 地址
        //        FROM tb_Patient";
        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        //    sqlDataAdapter.SelectCommand = sqlCommand;
        //    sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
        //    this.PatientTable = new DataTable();
        //    sqlConnection.Open();
        //    sqlDataAdapter.Fill(this.PatientTable);
        //    sqlConnection.Close();
        //    this.PatientViewByName = new DataView();
        //    this.PatientViewByName.Table = this.PatientTable;
        //    this.PatientViewByName.Sort = "姓名 ASC";
        //}
        //public void SelectPatientByNo(string no, DataTable PatientTable)
        //{
        //    DataRow resultRow = PatientTable.Rows.Find(no);
        //    this.ResultTable = PatientTable.Clone();
        //    this.ResultTable.ImportRow(resultRow);
        //}
        //public void SelectPatientByName(string name, DataView PatientViewByName)
        //{
        //    DataRowView[] resultRowView =
        //        PatientViewByName.FindRows(name);
        //    this.ResultTable = this.PatientTable.Clone();
        //    foreach (DataRowView dataRowView in resultRowView)
        //    {
        //        this.ResultTable.ImportRow(dataRowView.Row);
        //    }
        //}

        //public void RefreshRowFilter()
        //    => this.CurrentPageView.RowFilter =
        //    $"RowId>{(this.CurrentPageNo - 1) * this.PageSize}" +
        //    $"AND RowId<={(this.CurrentPageNo) * this.PageSize}";
        ///// <summary>
        ///// 浏览药品
        ///// </summary>
        //public void ViewMedicine()
        //{
        //    this.PageSize = 5;
        //    this.CurrentPageNo = 1;
        //    SqlConnection sqlConnection = new SqlConnection();
        //    sqlConnection.ConnectionString =
        //        ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
        //    SqlCommand sqlCommand = new SqlCommand();
        //    sqlCommand.Connection = sqlConnection;
        //    sqlCommand.CommandText = "SELECT * FROM tb_Unit";
        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        //    sqlDataAdapter.SelectCommand = sqlCommand;
        //    sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
        //    this.UnitTable = new DataTable();
        //    this.MedicineTable = new DataTable();
        //    this.MedicineTable.TableName = "Medicine";
        //    DataColumn rowIdColumn = new DataColumn();
        //    rowIdColumn.ColumnName = "RowId";
        //    rowIdColumn.DataType = typeof(int);
        //    rowIdColumn.AutoIncrement = true;
        //    rowIdColumn.AutoIncrementSeed = 1;
        //    rowIdColumn.AutoIncrementStep = 1;
        //    this.MedicineTable.Columns.Add(rowIdColumn);
        //    sqlConnection.Open();
        //    sqlDataAdapter.Fill(this.UnitTable);
        //    sqlCommand.CommandText = "SELECT * FROM tb_Medicine";
        //    sqlDataAdapter.Fill(this.MedicineTable);
        //    sqlConnection.Close();
        //    this.MedicineViewByName = new DataView();
        //    this.MedicineViewByName.Table = this.MedicineTable;
        //    this.MedicineViewByName.Sort = "Name ASC";
        //}
        ///// <summary>
        ///// 通过编号搜索药品
        ///// </summary>
        ///// <param name="no"></param>
        ///// <param name="MedicineTable"></param>
        //public void SelectMedicineByNo(string no, DataTable MedicineTable)
        //{
        //    DataRow resultRow = MedicineTable.Rows.Find(no);
        //    this.ResultTable = MedicineTable.Clone();
        //    this.ResultTable.ImportRow(resultRow);
        //}
        ///// <summary>
        ///// 通过名称搜索药品
        ///// </summary>
        ///// <param name="name"></param>
        ///// <param name="MedicineViewByName"></param>
        //public void SelectMedicineByName(string name, DataView MedicineViewByName)
        //{
        //    DataRowView[] resultRowView =
        //        MedicineViewByName.FindRows(name);
        //    this.ResultTable = this.MedicineTable.Clone();
        //    foreach (DataRowView dataRowView in resultRowView)
        //    {
        //        this.ResultTable.ImportRow(dataRowView.Row);
        //    }
        //}
        ///// <summary>
        ///// 通过拼音搜索药品
        ///// </summary>
        ///// <param name="pinyin"></param>
        //public void SelectMedicineByPinyin(string pinyin)
        //{
        //    DataRow[] resultRow =
        //        this.MedicineTable.Select($"Pinyin LIKE '%{pinyin}%'");
        //    this.ResultTable = this.MedicineTable.Clone();
        //    foreach (DataRow row in resultRow)
        //    {
        //        this.ResultTable.ImportRow(row);
        //    }

        //}
        //public void PrePage()
        //{
        //    if (CurrentPageNo > 1)
        //    {
        //        this.CurrentPageNo--;
        //        this.RefreshRowFilter();
        //    }
        //}
        //public void NextPage()
        //{
        //    if (CurrentPageNo < this.MaxPageNo)
        //    {
        //        this.CurrentPageNo++;
        //        this.RefreshRowFilter();
        //    }
        //}
    }
}
