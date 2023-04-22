using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutpatientWorkstation.BusinessLogicLayer
{
    public  interface IUserBll
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        int AgencyTypeNo { get; }
        /// <summary>
		/// 是否完成登录；
		/// </summary>
		bool HasLoggedIn { get; }
        /// <summary>
        /// 是否完成注册；
        /// </summary>
        bool HasSignedUp { get; }
        /// <summary>
        /// 消息；
        /// </summary>
        string Message { get; }
        DataSet DataSet { get; }
        DataTable DepartmentTable { get; }
        DataTable TechnicalOfficeTable { get; }
        DataTable AgencyTable { get;  }
        DataTable AgencyTypeTable { get;  }

        /// <summary>
        /// 检查是否存在；
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns>是否存在</returns>
        bool CheckExist(string userName);
        /// <summary>
        /// 检查是否不存在；
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns>是否不存在</returns>
        bool CheckNotExist(string userName);
        /// <summary>
        /// 登录；
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>用户</returns>
        User LogIn(string userName, string password);
        /// <summary>
        /// 注册；
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>用户</returns>
        User SignUp(string userName, string password, string checkPassword);
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="oldPassword"></param>
        /// <param name="newPassword"></param>
        /// <param name="checkPassword"></param>
        /// <returns></returns>
        User ModifyPassword(string userName,string oldPassword,string newPassword,string checkPassword);
        int SelectUserNo(string userName);
        void ViewAgency();
        void AfterSelect(int technicalOfficeNo);
        void InsertAgencyInfo();
        void InsertAgency(int agencyTypeNo, string name, bool gender, string phone, int technicalOfficeNo, string remark);
    }
}
