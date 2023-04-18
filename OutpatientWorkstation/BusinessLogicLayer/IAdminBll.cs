using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutpatientWorkstation.BusinessLogicLayer
{
    public  interface IAdminBll
    {
        /// <summary>
        /// 是否完成登录；
        /// </summary>
        bool HasLoggedIn { get; }
        /// <summary>
        /// 消息；
        /// </summary>
        string Message { get; }
        /// <summary>
        /// 检查是否存在
        /// </summary>
        /// <param name="adminName"></param>
        /// <returns></returns>
        bool CheckExist(string adminName);
        /// <summary>
        /// 检查是否不存在
        /// </summary>
        /// <param name="adminName"></param>
        /// <returns></returns>
        bool CheckNotExist(string adminName);
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="adminName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Admin LogIn(string adminName, string password);
    }
}
