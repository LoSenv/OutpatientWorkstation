using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutpatientWorkstation.BusinessLogicLayer
{
    public  interface IUserBll
    {
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
        /// 确认密码一致
        /// </summary>
        /// <param name="newPassword"></param>
        /// <param name="checkPasword"></param>
        /// <returns></returns>
        bool CheckEqual(string newPassword, string checkPasword);
        /// <summary>
        /// 确认密码不一致
        /// </summary>
        /// <param name="newPassword"></param>
        /// <param name="checkPasword"></param>
        /// <returns></returns>
        bool CheckNotEqual(string newPassword, string checkPasword);
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
    }
}
