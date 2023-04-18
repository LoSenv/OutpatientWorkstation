using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutpatientWorkstation.DataAccessLayer
{
    public  interface IUserDal
    {
        /// <summary>
        /// 查询用户
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        User Select(string username);
        /// <summary>
        /// 查询用户计数
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        int SelectCount(string username);
        /// <summary>
        /// 插入用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        int InsertUser(User user);
        /// <summary>
        /// 更新密码
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        int UpdatePassword(User user);
    }
}
